using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int acumuladorPerfectos = 0;
            int  i  = 0 ;
            int sumaDivisores, j;
            Console.WriteLine("Ingrese la cantidad de numeros perfectos que desea encontrar");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine("Los siguientes numeros son perfectos: ");

            while(acumuladorPerfectos != input)
            {
                
                sumaDivisores = 0;
                i++;
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sumaDivisores = sumaDivisores + j;
                    }
                }
                if (sumaDivisores == i)
                {
                    Console.WriteLine(i);
                    acumuladorPerfectos++;
                }
            }
            Console.ReadLine();
        }
    }
}
