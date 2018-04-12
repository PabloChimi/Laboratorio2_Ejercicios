using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_9.v2
{
    class Program
    {
        static void Main(string[] args)
        {
             int i, altura;
            Console.WriteLine("Ingrese altura de la piramide");
            altura = int.Parse(Console.ReadLine());
            for (i = 0; i < altura; i++)
            {
                string value = new string(' ', 1 + (2*i)).Replace(" ", "*");
                Console.WriteLine(value);
            }
            Console.ReadLine();

        }
    }
}
