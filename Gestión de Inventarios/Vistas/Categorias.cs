using Gestión_de_Inventarios.Datos;
using Gestión_de_Inventarios.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_de_Inventarios
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
            // Nos aseguramos de que la tabla no genere columnas por su cuenta
            dgvCategorias.AutoGenerateColumns = false;
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        // Método para cargar o refrescar los datos en el DataGridView
        private void CargarCategorias()
        {
            // Usamos una copia de la lista para la edición
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = DatosGlobales.Categorias.ToList(); // .ToList() crea una copia
            dgvCategorias.Refresh();
        }

        private void AlternarModoEdicion(bool activar)
        {
            // Activa o desactiva la edición en la tabla
            dgvCategorias.ReadOnly = !activar;
            // La columna de ID no debe ser editable
            dgvCategorias.Columns["Id"].ReadOnly = true;

            // Cambia el texto del botón y la visibilidad de los botones
            btnEditarGuardar.Text = activar ? "Guardar Cambios" : "Editar";
            btnCancelar.Visible = activar;

            // Desactivamos otros botones para evitar otras acciones
            btnAgregarCategoria.Enabled = !activar;
            btnEliminarCategoria.Enabled = !activar;
            txtNombreCategoria.Enabled = !activar; // bloqueamos el textbox de agregar
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para la categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nuevoId = DatosGlobales.Categorias.Any() ? DatosGlobales.Categorias.Max(c => c.Id) + 1 : 1;
            Categoria nuevaCategoria = new Categoria(nuevoId, txtNombreCategoria.Text);
            DatosGlobales.Categorias.Add(nuevaCategoria);

            CargarCategorias();
            txtNombreCategoria.Clear();
        }

        private void btnEditarGuardar_Click(object sender, EventArgs e)
        {
            if (btnEditarGuardar.Text == "Editar")
            {
                if (dgvCategorias.Rows.Count == 0)
                {
                    MessageBox.Show("No hay categorías para editar.", "Aviso");
                    return;
                }
                AlternarModoEdicion(true);
            }
            else // Cuando el botón dice guardar cambios
            {
                foreach (DataGridViewRow fila in dgvCategorias.Rows)
                {
                    int idCategoria = Convert.ToInt32(fila.Cells["Id"].Value);
                    string nombreCategoria = Convert.ToString(fila.Cells["Nombre"].Value);

                    if (string.IsNullOrWhiteSpace(nombreCategoria))
                    {
                        MessageBox.Show($"La categoría con ID {idCategoria} no puede tener un nombre vacío.", "Validación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        // No salimos del modo edición para que el usuario pueda corregir
                    }

                    var categoriaAActualizar = DatosGlobales.Categorias.FirstOrDefault(c => c.Id == idCategoria);
                    if (categoriaAActualizar != null)
                    {
                        categoriaAActualizar.Nombre = nombreCategoria;
                    }
                }

                AlternarModoEdicion(false);
                MessageBox.Show("Cambios guardados con éxito.", "Éxito");
                CargarCategorias(); // Recargamos para reflejar los datos actualizados
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlternarModoEdicion(false);
            CargarCategorias(); // Recargamos los datos originales para descartar cambios
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione la categoría que desea eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idCategoriaSeleccionada = (int)dgvCategorias.CurrentRow.Cells["Id"].Value;
            bool tieneProductosAsociados = DatosGlobales.Productos.Any(p => p.CategoriaId == idCategoriaSeleccionada);

            if (tieneProductosAsociados)
            {
                MessageBox.Show("No se puede eliminar la categoría porque tiene productos asociados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar esta categoría?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                var categoriaAEliminar = DatosGlobales.Categorias.First(c => c.Id == idCategoriaSeleccionada);
                DatosGlobales.Categorias.Remove(categoriaAEliminar);
                CargarCategorias();
            }
        }
    }
}
