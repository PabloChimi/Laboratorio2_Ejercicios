using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_nro_20_Librerias;

namespace Ejercicio_Nro_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar prueba = new Dolar(1);
            Console.WriteLine(prueba.getCantidad());
            Pesos prueba2 = (Pesos)prueba;
            Console.WriteLine(prueba2.getCantidad());
            Console.ReadLine();
        }
    }
}
