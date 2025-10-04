using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Inventarios.Modelos
{
    /* Estructura para el objeto Categoría, contiene las 2 propiedades básicas que definen la
    categoría de productos en este sistema */
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Categoria(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
