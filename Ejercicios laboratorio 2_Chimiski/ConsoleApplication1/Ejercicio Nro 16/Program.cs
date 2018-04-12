using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_16
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Alumno alu1 = new Alumno();
            Alumno alu2 = new Alumno();
            Alumno alu3 = new Alumno();

            alu1.apellido = "Gomez";
            alu2.apellido = "Fernandez";
            alu3.apellido = "Alvarez";
            alu1.nombre = "Benito";
            alu2.nombre = "Martin";
            alu3.nombre = "Pepe";
            alu1.legajo = 001;
            alu2.legajo = 002;
            alu3.legajo = 003;

            alu1.Estudiar(1, 10);
            alu2.Estudiar(10, 10);
            alu3.Estudiar(1, 1);
            //Console.ReadLine();

            Console.WriteLine("{0,-20} {1,5} {1,5}\n", "Legajo", "Nombre", "Apellido");
            Console.WriteLine(alu1.Mostrar());
            Console.WriteLine(alu2.Mostrar());
            Console.WriteLine(alu3.Mostrar());
            Console.ReadLine();

        }
    }
}
