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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            dgvProductos.AutoGenerateColumns = false;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            CargarComboBoxCategorias();
            CargarProductos();
        }

        private void CargarComboBoxCategorias()
        {
            // Cargar las categorías en el ComboBox 
            cmbCategoria.DataSource = DatosGlobales.Categorias;
            cmbCategoria.DisplayMember = "Nombre"; // Lo que el usuario ve
            cmbCategoria.ValueMember = "Id"; // El valor interno para nosotros
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = CargarListaParaEdicion();
            dgvProductos.Refresh();
        }

        private object CargarListaParaEdicion()
        {

            // Para mostrar el nombre de la categoría en lugar del ID, hacemos una consulta LINQ.
            var listaProductos = from p in DatosGlobales.Productos
                                 join c in DatosGlobales.Categorias on p.CategoriaId equals c.Id
                                 select new ProductoVM
                                 {
                                     ID = p.Id,
                                     Producto = p.Nombre,
                                     Precio = p.PrecioUnitario,
                                     Stock = p.Stock,
                                     Categoria = c.Nombre
                                 };
            return listaProductos.ToList();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Validación");
                return;
            }
            if (numPrecioUnitario.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a cero.", "Validación");
                return;
            }
            if (numCantidadInicial.Value < 0)
            {
                MessageBox.Show("La cantidad inicial no puede ser negativa.", "Validación");
                return;
            }

            // Creamos el nuevo producto
            int nuevoId = DatosGlobales.Productos.Count > 0 ? DatosGlobales.Productos.Max(p => p.Id) + 1 : 1;
            Producto nuevoProducto = new Producto(
                id: nuevoId,
                nombre: txtNombreProducto.Text,
                precioUnitario: numPrecioUnitario.Value,
                stock: (int)numCantidadInicial.Value,
                categoriaId: (int)cmbCategoria.SelectedValue
            );

            DatosGlobales.Productos.Add(nuevoProducto);

            // Registrar la cantidad inicial como un movimiento de entrada
            if (nuevoProducto.Stock > 0)
            {
                int movId = DatosGlobales.Movimientos.Count > 0 ? DatosGlobales.Movimientos.Max(m => m.Id) + 1 : 1;
                Movimiento movInicial = new Movimiento(movId, nuevoProducto.Id, DateTime.Now, "Entrada (Inicial)", nuevoProducto.Stock);
                DatosGlobales.Movimientos.Add(movInicial);
            }

            CargarProductos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            // Validar que haya una fila seleccionada
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione el producto que desea eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idProductoSeleccionado = (int)dgvProductos.CurrentRow.Cells["ID"].Value;

            bool tieneMovimientosReales = DatosGlobales.Movimientos.Any(m =>
                m.ProductoId == idProductoSeleccionado && m.TipoMovimiento != "Entrada (Inicial)"); //para que permita eliminar si su único movimiento es la carga inicial

            if (tieneMovimientosReales)
            {
                MessageBox.Show("No se puede eliminar este producto porque tiene un historial de entradas o salidas registradas.", "Operación denegada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este producto? Esta acción no se puede deshacer.", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                // Buscamos todos los movimientos de entrada iniciales para este producto y se limpia
                var movimientosInicialesAEliminar = DatosGlobales.Movimientos
                    .Where(m => m.ProductoId == idProductoSeleccionado && m.TipoMovimiento == "Entrada (Inicial)")
                    .ToList(); // Usamos ToList() para crear una copia y evitar errores al modificar la colección que recorremos.

                // Los eliminamos de la lista global de movimientos.
                foreach (var movimiento in movimientosInicialesAEliminar)
                {
                    DatosGlobales.Movimientos.Remove(movimiento);
                }

                // Buscamos el producto en la lista global y lo eliminamos
                var productoAEliminar = DatosGlobales.Productos.First(p => p.Id == idProductoSeleccionado);
                DatosGlobales.Productos.Remove(productoAEliminar);

                // Actualizamos la vista
                CargarProductos();
                MessageBox.Show("Producto eliminado con éxito.", "Éxito");
            }
        }

        // Método para controlar el modo editar
        private void AlternarModoEdicion(bool activar)
        {

            if (activar)
            {
                /* Al entrar en modo edición, desconectamos la tabla de la fuente de datos para que deje modificar*/
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = CargarListaParaEdicion(); // copia temporal
            }

            // Activa o desactiva la edición en la tabla
            dgvProductos.ReadOnly = !activar;

            // El ID no debe permitirse modificar
            dgvProductos.Columns["ID"].ReadOnly = true;
            dgvProductos.Columns["Cantidad"].ReadOnly = true;

            // Cambia el texto del botón y la visibilidad de los botones.
            btnEditarGuardar.Text = activar ? "Guardar Cambios" : "Editar";
            btnCancelar.Visible = activar;

            // Desactivamos otros botones para evitar acciones durante la edición.
            btnAgregarProducto.Enabled = !activar;
            btnEliminarProducto.Enabled = !activar;
        }

        private void btnEditarGuardar_Click(object sender, EventArgs e)
        {
            if (btnEditarGuardar.Text == "Editar")
            {
                if (dgvProductos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay productos para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                AlternarModoEdicion(true);
            }
            else // si el botón dice Guardar Cambios
            {
                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    int idProducto = Convert.ToInt32(fila.Cells["ID"].Value);
                    string nombreProducto = Convert.ToString(fila.Cells["Producto"].Value);

                    // Leemos el valor de la celda de Precio
                    var valorCeldaPrecio = fila.Cells["Precio"].Value;

                    // Validación del nombre
                    if (string.IsNullOrWhiteSpace(nombreProducto))
                    {
                        MessageBox.Show($"El producto con ID {idProducto} no puede tener un nombre vacío.", "Validación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    /* Validación del precio
                    Usamos decimal.TryParse para convertir controladamente y evitar errores si el usuario escribe texto*/
                    if (!decimal.TryParse(Convert.ToString(valorCeldaPrecio), out decimal nuevoPrecio) || nuevoPrecio <= 0)
                    {
                        MessageBox.Show($"El precio para el producto con ID {idProducto} no es válido. Debe ser un número mayor a cero.", "Validación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Buscamos el producto en nuestra lista de datos globales
                    var productoAActualizar = DatosGlobales.Productos.FirstOrDefault(p => p.Id == idProducto);
                    if (productoAActualizar != null)
                    {
                        // Actualizamos valores en nuestra fuente de datos
                        productoAActualizar.Nombre = nombreProducto;
                        productoAActualizar.PrecioUnitario = nuevoPrecio; 
                    }
                }

                // Si todo sale bien, salimos del modo edición
                AlternarModoEdicion(false);
                MessageBox.Show("Cambios guardados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Salimos del modo edición sin guardar nada
            AlternarModoEdicion(false);

            /* Recargamos los datos desde la fuente original para deshacer
            cualquier cambio visual que el usuario haya hecho en la tabla*/
            CargarProductos();
        }
    }
}
