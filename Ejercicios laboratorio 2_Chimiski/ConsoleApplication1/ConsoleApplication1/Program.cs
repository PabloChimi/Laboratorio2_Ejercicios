using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 0;
            float prom = 0;
            int flag = 0;
            int max = 0, min = 0, input = 0;
            bool valido;

            while (n < 5)
            {
                valido = int.TryParse(Console.ReadLine(), out input);
                if (valido)
                {
                    if (flag == 0)
                    {
                        max = input;
                        min = input;
                        flag = 1;
                    }

                    if (max < input)
                    {
                        max = input;
                    }
                    if (min > input)
                    {
                        min = input;
                    }
                    prom = prom + input;
                    n++;
                }
                
            }
            prom = prom / n;
            Console.WriteLine("{0},{1}", "El maximo es: ", max);
            Console.WriteLine("{0}, {1}" , "El minimo es: ", min);
            Console.WriteLine("{0}, {1}", "El promedio es: ", prom);
            Console.ReadLine();

        }
    }
}
