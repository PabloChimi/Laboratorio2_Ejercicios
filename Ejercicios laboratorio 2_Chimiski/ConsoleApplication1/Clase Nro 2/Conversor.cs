using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Nro_2
{
    public class Conversor
    {
        
        public static string ConvertirEntero(int numero)
        {  
            string binario = "";
             while(numero != 0)
            {
                if(numero%2 == 0)
                {
                    numero = numero/2;
                    binario =  "0" + binario;
                }else{
                    numero = (numero-1)/2;
                    binario = "1" + binario;
                }
            }
            return binario;
        }

        public static double convertirBinario(string binario)
        {
            int i;
            double numero = 0;
            int longitudBinario = binario.Length;
            for(i = 0; i < longitudBinario; i++)
            {
                Console.Write("Largo de string:");
                Console.WriteLine(binario.Length);
                if(Char.GetNumericValue(binario.First()) == 1)
                {
                    Console.Write("Sumo:");
                    
                    numero = numero + Math.Pow(2, binario.Length - 1);
                    Console.WriteLine(numero);
                }
                binario = binario.Remove(0, 1);    
            }
            return numero;
        }
       


    }
}


