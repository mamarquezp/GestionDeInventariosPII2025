using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Inventarios.Modelos
{
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
