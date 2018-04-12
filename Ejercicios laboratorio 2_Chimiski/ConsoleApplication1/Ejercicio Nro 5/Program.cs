using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int acumuladorInferior, acumuladorSuperior;
            int i, j;
            int candidatoCentro;
            Console.WriteLine("Ingrese hasta que numero desea encontrar centros numericos");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine("Los siguientes numeros son centros numericos: ");

            for(i = 2 ; i < input ; i++)
            {
                acumuladorInferior = 0;
                acumuladorSuperior = 0;
                for (j = 1; j < i; j++)
                {
                    acumuladorInferior = acumuladorInferior + j;
                }
                candidatoCentro = i;
                while(acumuladorSuperior < acumuladorInferior)
                {
                    candidatoCentro++;
                    acumuladorSuperior = acumuladorSuperior + candidatoCentro;
                }
                if(acumuladorSuperior == acumuladorInferior)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
        
    }
}
