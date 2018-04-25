using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_31
{
    class Program
    {
        static void Main(string[] args)
        {
            PuestoAtencion p = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            Negocio n = new Negocio("El buena onda");
            Cliente juan = new Cliente(2);
            Cliente jorge = new Cliente(3);
            Cliente ejemplo = new Cliente(0);

            Console.WriteLine("El numero es {0}", juan.Numero);
            Console.WriteLine("El numero es {0}", jorge.Numero);

            if (n+juan)
            {
                Console.WriteLine("Cliente agregado");
            }
            else
            {
                Console.WriteLine("Cliente no agregado");
            }
            if (n + juan)
            {
                Console.WriteLine("Cliente agregado");
            }
            else
            {
                Console.WriteLine("Cliente no agregado");
            }
            if (n + jorge)
            {
                Console.WriteLine("Cliente agregado");
            }
            else
            {
                Console.WriteLine("Cliente no agregado");
            }
            if( (-n) )
            {
                Console.WriteLine("Cliente atendido");
            }
            while(!ReferenceEquals(ejemplo,null))
            {
                ejemplo = n.Cliente;
                Console.WriteLine("Pase");
            }
            while (!ReferenceEquals(ejemplo, null))
            {
                ejemplo = n.Cliente;
                Console.WriteLine("Pase");
            }
            Console.ReadLine();

            //No entiendo el sentido de tener el numero actual, el problema esta cuando creo un nuevo cliente al agregar y le agrego el "numero actual";
        }
    }
}
