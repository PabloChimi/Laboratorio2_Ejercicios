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
                return clientes.Dequeue();
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

        public Negocio(string nombre)
        {
            this.nombre = nombre;
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            return n.clientes.Contains(c);
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
                n.caja.Atender(n.clientes.Dequeue());
                return true;
            }
            return false;
        }

    }
}
