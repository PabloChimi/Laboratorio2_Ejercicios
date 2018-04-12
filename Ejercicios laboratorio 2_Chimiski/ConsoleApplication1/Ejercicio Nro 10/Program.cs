using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, altura;
            string ladrillos, espacios;
            Console.WriteLine("Ingrese altura de la piramide");
            altura = int.Parse(Console.ReadLine());
            espacios =  new string(' ', altura - 1);
            for (i = 0; i < altura; i++)
            {
                espacios = new string(' ', altura - i);
                Console.Write(espacios);
                ladrillos = new string(' ', 1 + (2 * i)).Replace(" ", "*");
                Console.WriteLine(ladrillos);
            }
            Console.ReadLine();
        }
    }
}
