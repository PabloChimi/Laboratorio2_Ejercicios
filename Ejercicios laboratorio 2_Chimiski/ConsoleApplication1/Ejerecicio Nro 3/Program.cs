using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerecicio_Nro_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int i, j, cantDivisores;
            Console.WriteLine("Ingrese un numero natural positivo: ");
            input = int.Parse(Console.ReadLine());

            Console.WriteLine("Los numeros primos hasta el numero ingresado son: ");
            for (i = 2; i <= input; i++)
            {
                cantDivisores = 0;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        cantDivisores++;
                    }
                }
                if (cantDivisores == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
