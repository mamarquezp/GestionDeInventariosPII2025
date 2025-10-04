using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Inventarios.Modelos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Stock { get; set; } // Cantidad actual en inventario.
        public int CategoriaId { get; set; } // Llave para contectarlo con la categoría.

        // Constructor
        public Producto(int id, string nombre, decimal precioUnitario, int stock, int categoriaId)
        {
            Id = id;
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            Stock = stock;
            CategoriaId = categoriaId;
        }
    }
}
