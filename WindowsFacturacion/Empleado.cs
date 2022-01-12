using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFacturacion
{
    public class Empleado : Persona
    {
        public Empleado(string apellido, string nombre, string dni,string legajo) : base(apellido, nombre, dni)
        {
            Legajo = legajo;

        }


        public string Legajo { get; set; }

    }
}
