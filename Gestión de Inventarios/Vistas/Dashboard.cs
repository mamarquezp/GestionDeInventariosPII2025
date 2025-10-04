using Gestión_de_Inventarios.Datos;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ActualizarKPIs();
        }

        /* Este evento se dispara cada vez que el formulario vuelve a ser el foco,
        así los datos siempre están actualizados */
        private void Dashboard_Activated(object sender, EventArgs e)
        {
            ActualizarKPIs();
        }

        private void ActualizarKPIs()
        {
            // Número total de productos
            lblTotalProductos.Text = DatosGlobales.Productos.Count.ToString();

            // Número total de categorías
            lblTotalCategorias.Text = DatosGlobales.Categorias.Count.ToString();

            // Valor total del inventario
            decimal valorTotalInventario = DatosGlobales.Productos.Sum(p => p.PrecioUnitario * p.Stock);
            lblValorInventario.Text = valorTotalInventario.ToString("C"); // "C" formatea como moneda: Q 2,500.00

            // Producto con mayor stock
            if (DatosGlobales.Productos.Any())
            {
                var productoMayorStock = DatosGlobales.Productos.OrderByDescending(p => p.Stock).First();
                lblMayorStock.Text = $"{productoMayorStock.Nombre} ({productoMayorStock.Stock} unidades)";
            }
            else
            {
                lblMayorStock.Text = "N/A";
            }
        }

        // Botones de navegación
        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos formProductos = new Productos();
            formProductos.ShowDialog(); // ShowDialog hace que mientras esté abierta esta nueva ventana, se bloquea la anterior
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Categorias formCategorias = new Categorias();
            formCategorias.ShowDialog();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            Movimientos formMovimientos = new Movimientos();
            formMovimientos.ShowDialog();
        }
    }
}
