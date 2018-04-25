using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                if (clientes.Count == 0)
                {
                    return null;
                }
                else
                {
                    return clientes.Dequeue();
                }
            }
            set
            {
                if (!clientes.Contains(value))
                {
                    clientes.Enqueue(value);
                }
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            //Array arrayPrueba = Array.CreateInstance(typeof(Cliente), n.clientes.Count);
            Cliente[] myStandardArray = n.clientes.ToArray();
            for (int i = 0; i <myStandardArray.Length; i++)
            {
                Console.WriteLine("Paso para ver si esta");
                Console.WriteLine("El cliente {0} es igual a {1}", myStandardArray[i].Numero, c.Numero);
                if (myStandardArray[i] == c)
                {
                    Console.WriteLine("El cliente {0} es igual a {1}", myStandardArray[i].Numero, c.Numero);
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                Cliente nuevoCliente = new Cliente(PuestoAtencion.NumeroActual, c.Nombre);
                n.clientes.Enqueue(nuevoCliente);
                return true;
            }
            return false;
        }

        public static bool operator -(Negocio n)
        {
            if (n.clientes.Count != 0)
            {
                n.caja.Atender(n.Cliente);
                return true;
            }
            return false;
        }

    }
}
