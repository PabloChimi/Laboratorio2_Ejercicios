using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centralita_2._0
{
    public partial class Llamador : Form
    {
        public Llamador()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "#";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string destino = textBox1.Text;
            string origen = textBox2.Text;
            Provincial.Franja franja = (Provincial.Franja) comboBox1.SelectedIndex; 
            Random tiempo = new Random();

            Llamada.TipoLlamada llamada = Llamada.TipoLlamada.Local;
            if (textBox1.Text[1] == '#')
            {
                llamada = Llamada.TipoLlamada.Provincial;
                Provincial llamadaProvincial = new Provincial(origen, franja, (float)tiempo.Next(1, 200), destino);
            }
            else
            {
                llamada = Llamada.TipoLlamada.Local;
                Local llamadaLocal = new Local(origen, tiempo.Next(1, 200), destino, (float)tiempo.Next(1, 200));
            }
            
        }
    }
}
