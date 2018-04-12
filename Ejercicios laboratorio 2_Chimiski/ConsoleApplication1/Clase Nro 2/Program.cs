using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase_Nro_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int seguir = 1;
            int opcion, valorEntero;
            double valorEnteroDoble;
            string valorBinario;
            while (seguir == 1)
            {
                Console.WriteLine("1 - Convertir de binario a entero");
                Console.WriteLine("2 - Convertir de entero a binario");
                Console.WriteLine("3 - Salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el valor Binario en ASCII a convertir a entero");
                        valorBinario = Console.ReadLine();
                        valorEnteroDoble = Conversor.convertirBinario(valorBinario);
                        Console.WriteLine(valorEnteroDoble);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el valor entero a convertir a binario");
                        valorEntero = int.Parse(Console.ReadLine());
                        valorBinario = Conversor.ConvertirEntero(valorEntero);
                        Console.WriteLine(valorBinario);
                        break;
                    case 3:
                        seguir = 0;
                        break;
                }
            }
        }
    }
}
