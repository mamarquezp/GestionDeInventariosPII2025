using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Inventarios.Modelos
{
    public class Movimiento
    {
        public int Id { get; set; }
        public int ProductoId { get; set; } // Para saber de qué producto fue el movimiento
        public DateTime Fecha { get; set; } // Cuándo se hizo el movimiento
        public string TipoMovimiento { get; set; } // Si será "Entrada" o "Salida"
        public int Cantidad { get; set; }

        public Movimiento(int id, int productoId, DateTime fecha, string tipoMovimiento, int cantidad)
        {
            Id = id;
            ProductoId = productoId;
            Fecha = fecha;
            TipoMovimiento = tipoMovimiento;
            Cantidad = cantidad;
        }
    }
}
