using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_nro_20_Librerias;

namespace Ejercicio_Nro_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valorPrueba;
            double valor = double.Parse(textBox1.Text);
            Euro euro = new Euro(valor);
            textBox2.Text = textBox1.Text;
            Dolar dolar = (Dolar) euro;
            textBox3.Text = String.Format("{0}", dolar.getCantidad());
            Pesos pesos = (Pesos) dolar;
            valorPrueba = pesos.getCantidad();
            textBox4.Text = String.Format("{0}", pesos.getCantidad());

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(textBox8.Text);
            Dolar dolar = new Dolar(valor);

            textBox10.Text = textBox8.Text;

            Euro euro = (Euro)dolar;
            textBox9.Text = String.Format("{0}", euro.getCantidad());

            Pesos pesos = (Pesos)dolar;
            textBox11.Text = String.Format("{0}", pesos.getCantidad());

        }
    }
}
