using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Inventarios.Modelos
{
    /* Este es un ViewModel y sirve para que permita gestionar las modificaciones del grid, 
    pues a diferencia de los objetos del LINQ esta si permite editarlos, también ofrece una
    mejor visibilidad al mostrar la propiedad de nombre de Categoría en lugar de su ID */
    public class ProductoVM
    {
        public int ID { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Categoria { get; set; }
    }
}
