using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFacturacion
{
    public class Factura
    {


        public List<DetalleFactura> DetalleFacturas { get; set; }
        public Empleado Empleado { get; set; }
        public Cliente Cliente { get; set; }

    }
}
