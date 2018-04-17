﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Nro_1_laboratorio_2
{
    public class Numero
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

        public double operator -(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public double operator +(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }

        private double ValidarNumero(string strNumero)
        {
            double n;
            bool isNumeric = double.TryParse(strNumero, out n);
            if (isNumeric)
            {
                return n;
            }
            return 0;
        }

    }
}