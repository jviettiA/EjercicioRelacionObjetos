using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFacturacion
{
    public class Usuario : Persona
    {
        public Usuario(string apellido, string nombre, string dni) : base(apellido, nombre, dni)
        {
        }
    }
}
