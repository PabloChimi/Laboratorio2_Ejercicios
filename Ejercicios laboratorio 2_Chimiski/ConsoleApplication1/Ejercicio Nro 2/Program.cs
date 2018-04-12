using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int input = 0;
            double cuadrado = 0, cubo = 0;
            while(n == 0)
            {
                input = int.Parse(Console.ReadLine());
                if (input > 0)
                {
                    cuadrado = Math.Pow(input, 2);
                    cubo = Math.Pow(input, 3);
                    n = 1;
                }
                else
                {
                    Console.WriteLine("ERROR: Reingresar numero!");
                }
            }
            Console.WriteLine("{0},{1}", "El cuadrado es: ", cuadrado);
            Console.WriteLine("{0},{1}", "El cubo es: ", cubo);
            Console.ReadLine();
        }
    }
}
