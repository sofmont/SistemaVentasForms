using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasForms
{
    internal class OrdenVenta
    {
        public List<DetalleOrden> Detalles { get; } = new List<DetalleOrden>();
        private DateTime fecha;
        public OrdenVenta() { }
    }
}
