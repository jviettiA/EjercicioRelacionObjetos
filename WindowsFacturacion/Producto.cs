using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFacturacion
{
    public class Producto
    {

        public Producto(string nombre, float precio, Categoria categoria) {
            
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }

        public string Nombre { get; set; }

        public float Precio { get; set; }

        public Categoria Categoria { get; set; }
        public List<DetalleFactura> DetalleFacturas { get; set; }

    }
}
