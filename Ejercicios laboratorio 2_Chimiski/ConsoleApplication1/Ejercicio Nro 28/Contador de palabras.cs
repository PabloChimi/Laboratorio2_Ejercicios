using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Nro_28
{
    public partial class Contador_de_palabras : Form
    {
        public Contador_de_palabras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inicio = 0;
            int fin;
            string texto = textBox1.Text;
            Dictionary<string, int> aparicionPalabras = new Dictionary<string, int>();

            for(int i = 0 ; i<texto.Length ; i++)
            {
                if (texto[i] == ' ')
                {
                    fin = i;
                    if (aparicionPalabras.ContainsKey(texto.Substring(inicio, fin - inicio)))
                    {
                        aparicionPalabras[texto.Substring(inicio, fin - inicio)] = +1;
                    }
                    else
                    {
                        aparicionPalabras.Add(texto.Substring(inicio, fin - inicio), 1);
                    }
                    inicio = i + 1;
                }

            }

            Dictionary<string, int>.KeyCollection keyColl = aparicionPalabras.Keys;
            foreach( string s in keyColl )
            {
                Console.WriteLine("La palabra {0} tiene {1} apariciones.", s, aparicionPalabras[s]);
            }
            Console.ReadLine();

        }
    }
}
