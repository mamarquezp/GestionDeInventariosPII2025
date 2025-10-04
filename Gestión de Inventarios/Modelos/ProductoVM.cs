using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Inventarios.Modelos
{
    // para que permita gestionar las modificaciones del grid
    public class ProductoVM
    {
        public int ID { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Categoria { get; set; }
    }
}
