using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFacturacion
{
    public class Cliente : Persona
    {
        public Cliente(string apellido, string nombre, string dni) : base(apellido, nombre, dni)
        {
        }


        public List<Factura> Facturas { get; set; }
        public Usuario Usuario { get; set; }
    }
}
