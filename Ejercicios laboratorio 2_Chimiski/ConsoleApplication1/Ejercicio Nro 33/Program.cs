using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro pancho = new Libro();
            pancho[2] = "El perro";
            Console.WriteLine("{0},{1}", pancho[2], pancho[11]);
            pancho[11] = "Feo";
            Console.WriteLine("{0},{1}", pancho[2], pancho[11]);
            Console.ReadLine();
        }
    }
}
