using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_11
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int sumaValores = 0, min = 0, max = 0;
            int valorRecibido;
            while(i < 10)
            {
                Console.WriteLine("Ingrese un valor entre -100 y 100");
                valorRecibido = int.Parse(Console.ReadLine());

                if(!Validacion.Validar(valorRecibido, -100, 100))
                {
                    Console.WriteLine("No se ingreso valor en rango");
                    continue;
                }

                if(i==0)
                {
                    min = valorRecibido;
                    max = valorRecibido;
                    sumaValores = valorRecibido;
                }else{
                    if(min > valorRecibido)
                    {
                        min = valorRecibido;
                    }
                    if(max < valorRecibido)
                    {
                        max = valorRecibido;
                    }
                    sumaValores = sumaValores + valorRecibido;
                }
                i++;
            }
            Console.WriteLine("{0},{1}" , "El valor minimo es: ", min);
            Console.WriteLine("{0},{1}", "El valor maximo es: ", max);
            Console.WriteLine("{0},{1}", "El promedio es: ", sumaValores / i);
            Console.ReadLine();
        }
    }
}
