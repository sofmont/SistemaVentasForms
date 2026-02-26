using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasForms
{
    public partial class Form1 : Form
    {
        List<Producto> inventario = new List<Producto>();
List<Producto> carritoActual = new List<Producto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearOrden_Click_1(object sender, EventArgs e)
        {            if (carritoActual.Count == 0)
            {
                MessageBox.Show("El carrito está vacío, no hay nada que cobrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DetalleOrden ordenFinal = new DetalleOrden(carritoActual);

            MessageBox.Show(ordenFinal.ToString(), "Ticket de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);

          
            carritoActual.Clear();
            lstCarrito.Items.Clear();

        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            Producto productoSeleccionado = cmbProductos.SelectedItem as Producto;
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Por favor seleccione un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)nudCantidad.Value;
            for (int i = 0; i < cantidad; i++)
            {
                carritoActual.Add(productoSeleccionado);
                    lstCarrito.Items.Add($"- {productoSeleccionado.Nombre} (${productoSeleccionado.Precio})");
            }
            nudCantidad.Value = 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Crea
            inventario.Add(new Producto { Nombre = "Teclado Mecánico", Precio = 850.50 });
            inventario.Add(new Producto { Nombre = "Mouse Inalámbrico", Precio = 320.00 });
            inventario.Add(new Producto { Nombre = "Monitor 24 pulgadas", Precio = 2500.00 });
            inventario.Add(new Producto { Nombre = "Cable HDMI", Precio = 150.00 });

            // Magia pura de Windows Forms: conectamos la lista directo al ComboBox
            cmbProductos.DataSource = inventario;

            // Le decimos que solo muestre la propiedad "Nombre" en la pantalla
            cmbProductos.DisplayMember = "Nombre";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
