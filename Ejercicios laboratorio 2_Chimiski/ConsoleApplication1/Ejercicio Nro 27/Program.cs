using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cola = new Queue<int>(20);
            Stack<int> pila = new Stack<int>(20);
            List<int> lista = new List<int>(20);
            int contador = 0;
            Random r = new Random();
            int prueba;

            while (contador < 20)
            {
                prueba = r.Next();
                if (prueba != 0)
                {
                    if (r.Next() % 2 == 0)
                    {
                        cola.Enqueue(prueba);
                        pila.Push(prueba);
                        lista.Add(prueba);
                        contador++;
                    }
                    else
                    {
                        cola.Enqueue(prueba * (-1));
                        pila.Push(prueba * (-1));
                        lista.Add(prueba * (-1));
                        contador++;
                    }
                }
            }


            for (contador = 0; contador < 20; contador++)
            {
                Console.WriteLine(lista[contador]);
            }

            Console.WriteLine("\n\n\n Ordenada Positivos \n\n\n");
            lista.Sort(CompararEnterosDecreciente);
         
            for (contador = 0; contador < 20; contador++)
            {
                if (lista[contador] >= 0)
                {
                    Console.WriteLine(lista[contador]);
                }
            }
            
            Console.WriteLine("\n\n\n Ordenada negativos \n\n\n");
            lista.Sort(CompararEnteros);

            for (contador = 0; contador < 20; contador++)
            {
                if(lista[contador] <= 0)
                {
                    Console.WriteLine(lista[contador]);
                }
            }
           
            Console.ReadLine();
        }


        //Funciones de comparación.

        public static int CompararEnteros(int a, int b)
        {
            return Math.Sign(a.CompareTo(b));
        }
        public static int CompararEnterosDecreciente(int a, int b)
        {
            return (-1) * Math.Sign(a.CompareTo(b));
        }


    }
}
