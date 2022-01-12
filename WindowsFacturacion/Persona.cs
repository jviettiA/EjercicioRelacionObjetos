using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFacturacion
{
    public class Persona
    {

        public Persona(string apellido, string nombre, string dni)
        {
            Apellido = apellido;
            Nombre = nombre;
            DNI = dni;
        }

        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
    }
}
