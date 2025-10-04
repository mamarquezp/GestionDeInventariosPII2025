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
    public partial class Movimientos : Form
    {
        public Movimientos()
        {
            InitializeComponent();
        }

        private void Movimientos_Load(object sender, EventArgs e)
        {
            // Cargar productos en el ComboBox
            cmbProducto.DataSource = DatosGlobales.Productos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";

            // Cargar el historial al abrir
            CargarMovimientos();
        }
        private void CargarMovimientos()
        {
            // Creamos una consulta LINQ para unir los movimientos con los productos y obtener el nombre.
            var listaMovimientos = from m in DatosGlobales.Movimientos
                                   join p in DatosGlobales.Productos on m.ProductoId equals p.Id
                                   orderby m.Fecha descending // Ordenamos del más reciente al más antiguo
                                   select new
                                   {
                                       Fecha = m.Fecha,
                                       Producto = p.Nombre,
                                       TipoMovimiento = m.TipoMovimiento,
                                       Cantidad = m.Cantidad
                                   };

            dgvMovimientos.DataSource = null;
            dgvMovimientos.DataSource = listaMovimientos.ToList();
            dgvMovimientos.Refresh();
        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem == null || numCantidad.Value <= 0)
            {
                MessageBox.Show("Seleccione un producto y una cantidad válida.", "Validación");
                return;
            }

            int productoId = (int)cmbProducto.SelectedValue;
            int cantidad = (int)numCantidad.Value;
            var producto = DatosGlobales.Productos.First(p => p.Id == productoId);

            producto.Stock += cantidad;

            int movId = DatosGlobales.Movimientos.Any() ? DatosGlobales.Movimientos.Max(m => m.Id) + 1 : 1;
            Movimiento nuevoMovimiento = new Movimiento(movId, productoId, DateTime.Now, "Entrada", cantidad);
            DatosGlobales.Movimientos.Add(nuevoMovimiento);

            MessageBox.Show("Entrada registrada con éxito. Nuevo stock: " + producto.Stock, "Éxito");

            // Refrescamos la tabla
            CargarMovimientos();
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem == null || numCantidad.Value <= 0)
            {
                MessageBox.Show("Seleccione un producto y una cantidad válida.", "Validación");
                return;
            }

            int productoId = (int)cmbProducto.SelectedValue;
            int cantidad = (int)numCantidad.Value;
            var producto = DatosGlobales.Productos.First(p => p.Id == productoId);

            if (producto.Stock < cantidad)
            {
                MessageBox.Show("No hay suficiente stock para realizar esta salida. Stock actual: " + producto.Stock, "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            producto.Stock -= cantidad;

            int movId = DatosGlobales.Movimientos.Any() ? DatosGlobales.Movimientos.Max(m => m.Id) + 1 : 1;
            Movimiento nuevoMovimiento = new Movimiento(movId, productoId, DateTime.Now, "Salida", cantidad);
            DatosGlobales.Movimientos.Add(nuevoMovimiento);

            MessageBox.Show("Salida registrada con éxito. Nuevo stock: " + producto.Stock, "Éxito");

            // Refrescamos la tabla con el cambio
            CargarMovimientos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
