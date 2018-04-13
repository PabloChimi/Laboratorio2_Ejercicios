using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myVector = new int[20];
            int contador = 0;
            Random r = new Random();
            int prueba;
            while (contador < 20)
            {
                prueba = r.Next();
                if (prueba != 0)
                {
                    if (r.Next()%2 == 0)
                    {
                        myVector[contador] = prueba;
                        contador++;
                    }
                    else
                    {
                        myVector[contador] = prueba * (-1);
                        contador++;
                    }
                }
            }
            for (contador = 0; contador < 20; contador++)
            {
                Console.WriteLine(myVector[contador]);
            }
            Console.ReadLine();
        }
    }
}
