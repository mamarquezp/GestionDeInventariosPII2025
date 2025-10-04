using Gestión_de_Inventarios.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Inventarios.Datos
{
    public static class DatosGlobales
    {
        // Listas para almacenar todos los datos de la aplicación
        public static List<Categoria> Categorias { get; set; }
        public static List<Producto> Productos { get; set; }
        public static List<Movimiento> Movimientos { get; set; }

        /*El constructor se ejecuta una sola vez cuando se usa la clase por primera vez 
         y se carga algunos datos de pruebas o iniciales*/
        static DatosGlobales()
        {
            Categorias = new List<Categoria>()
        {
            new Categoria(1, "Abarrotes"),
            new Categoria(2, "Electrónicos"),
            new Categoria(3, "Limpieza")
        };

            Productos = new List<Producto>()
        {
            new Producto(1, "Laptop Dell Inspiron", 6500.00m, 10, 2),
            new Producto(2, "Detergente Ariel 1kg", 25.50m, 150, 3),
            new Producto(3, "Arroz Gallo Dorado 1lb", 5.75m, 200, 1)
        };

            Movimientos = new List<Movimiento>();
        }
    }
}
