using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, altura;
            Console.WriteLine("Ingrese altura de la piramide");
            altura = int.Parse(Console.ReadLine());
            for (i = 1; i < altura + 1; i++)
            {
                for (j = 0; j < i + (i-1); j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
