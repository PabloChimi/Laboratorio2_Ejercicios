using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_Nro_31
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto p)
        {
            puesto = p;
            numeroActual = 0;
        }

        public bool Atender(Cliente c)
        {
            Thread.Sleep(100);
            return true;
        }


        public enum Puesto
        {
            Caja1,
            Caja2
        }
    }
}
