using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVentasForms
{
    internal class DetalleOrden
    {
        public List<Producto> Productos { get; } = new List<Producto>();

        // Constructor
        public DetalleOrden(List<Producto> productos)
        {
            Productos = productos;
        }
        public int Cantidad
        {
            get
            {
                return Productos.Count;
            }
        }

        public decimal Subtotal()
        {
            decimal totalSuma = 0;
            foreach (var producto in Productos)
            {
               
                totalSuma += (decimal)producto.Precio;
            }
            return totalSuma;
        }

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("--- PRODUCTOS EN LA ORDEN ---");
            foreach (var producto in Productos)
            {
                sb.AppendLine(producto.ToString());
            }

            sb.AppendLine("-----------------------------");
            sb.AppendLine($"Cantidad de artículos: {Cantidad}");
            sb.AppendLine($"Subtotal a cobrar: ${Subtotal()}");

            return sb.ToString();
        }
    }
}