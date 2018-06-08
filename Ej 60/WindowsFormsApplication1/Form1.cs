using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Producto;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto.Producto p = new Producto.Producto(5, "ariel");
            Producto.ProductoDAO.AgregarProducto(p);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Producto.Producto> productos = Producto.ProductoDAO.ObtenerProducto();
            for (int i = 0; i < productos.Count; i++)
            {
                richTextBox1.Text = richTextBox1.Text + productos[i].Mostrar();
            }
        }
    }
}
