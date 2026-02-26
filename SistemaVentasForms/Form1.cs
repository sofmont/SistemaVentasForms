using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearOrden_Click(object sender, EventArgs e)
        {
            
            List<Producto> carritoPrueba = new List<Producto>();

            carritoPrueba.Add(new Producto("Teclado Mecánico", 850.50, 1));
            carritoPrueba.Add(new Producto("Mouse Inalámbrico", 320.00, 1));
            carritoPrueba.Add(new Producto("Monitor 24 pulgadas", 2500.00, 1));
       

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
