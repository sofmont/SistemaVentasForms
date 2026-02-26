using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasForms
{
    internal class DetalleOrden
    {
        public List<Producto> Productos { get; } = new List<Producto>();
        private int cantidad;
        private Producto precio;

        public DetalleOrden(List<Producto> productos)
        {
            Productos = productos;
        }

        public int Cantidad
        {
            get
            {
                int totalCantidad = 0;
                foreach (var producto in Productos)
                {
                    totalCantidad += 1;
                }
                return totalCantidad;
            }
        }
        public decimal Subtotal(int cantidad, Producto precio)
        {
            decimal subtotal = 0;
            foreach (var producto in Productos)
            {
                subtotal += (decimal)(cantidad * precio.Precio);
            }
            return subtotal;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var producto in Productos)
            {
                sb.AppendLine(producto.ToString());
            }
            sb.AppendLine($"Subtotal: ${Subtotal(cantidad, precio)}");
            sb.AppendLine($"Cantidad: ${Cantidad}");
            return sb.ToString();
        }


    }
}
