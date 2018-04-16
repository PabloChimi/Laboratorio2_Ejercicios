using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Nro_1_laboratorio_2
{
    class Numero
    {
        private double numero;
        
        public Numero()
        {

        }

        public Numero(string numero)
        {

        }

        public Numero(double numero)
        {

        }

        public string BinarioDecimal(string binario)
        {
            int i;
            double valorTotal = 0;

            for (i=0; i < binario.Length; i++)
            {
                if(char.Equals(binario[i],'1') )
                {
                    valorTotal = +Math.Pow(2, binario.Length - i);
                }
                else
                {
                    if(!char.Equals(binario[i], '0'))
                    {
                        return "Valor invalido";
                    }
                }
            }
            return valorTotal.ToString();

        }


    }
}
