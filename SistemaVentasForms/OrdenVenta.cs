using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasForms
{
    internal class OrdenVenta
    {
        public int NumeroOrden { get; set; }
        public DateTime FechaOperacion { get; set; }


        public List<DetalleOrden> Detalles { get; set; }


        public OrdenVenta()
        {
            Detalles = new List<DetalleOrden>();
            FechaOperacion = DateTime.Now;
        }
      

        public decimal TotalCobrado
        {
            get
            {
                decimal suma = 0;
                foreach (DetalleOrden renglon in Detalles)
                {
                    suma += renglon.Subtotal();
                }
                return suma;
            }
        }

        // Método para agregar un producto al carrito
        public void AgregarProducto(Producto producto, int cantidad)
        {
        //    Detalles.Add(new DetalleOrden(producto, cantidad));
        }
    }
}
