using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasForms
{
    internal class Persona
    {

        // Atributos privados
        private string nombre;
        private string telefono;
    

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
      
        public Persona() { }

        public Persona(string nombre, string telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
          
        }

        public override string ToString()
        {
            return $"{nombre} - {telefono}";
        }
    }
}
