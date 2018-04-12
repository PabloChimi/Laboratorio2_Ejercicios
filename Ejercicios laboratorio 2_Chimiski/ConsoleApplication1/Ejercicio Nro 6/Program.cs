using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Ingrese año que desea verificar si es bisiesto o no:");
            input = int.Parse(Console.ReadLine());

            if (input % 4 == 0)
            {
                if (input % 100 != 0)
                {
                    Console.WriteLine("Es año bisiesto!");
                }
                else
                {
                    if (input % 400 == 0)
                    {
                        Console.WriteLine("Es año bisiesto!");
                    }
                    else
                    {
                        Console.WriteLine("No es año bisiesto :(");
                    }
                }
            }
            else
            {
                Console.WriteLine("No es año bisiesto :(");
            }
            Console.ReadLine();
        }
    }
}
