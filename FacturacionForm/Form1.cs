using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFacturacion;

namespace FacturacionForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Producto> products = new List<Producto>();

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria("Alimento");
            Producto prod = new Producto("Jugo",23,cat);
            products.Add(prod);
            cat.Nombre = "Indumentaria";
            Producto prod2 = new Producto("Remera",140,cat);
            products.Add(prod2);
            dataGridView1.DataSource = products;

        }
    }
}
