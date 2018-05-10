using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public float Monto
        {
            get
            {
                return this.monto;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                if(DateTime.Compare(value, DateTime.Now) < 0)
                {
                    this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = DateTime.Now;
                }
            }
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.Vencimiento = vencimiento;
        }

        abstract public void ExtenderPlazo(DateTime nuevoVencimiento);
        
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Vencimiento: {0,2} Monto: {1,-10}", this.Vencimiento, this.Monto);
            return sb.ToString();
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            int retorno = 0;
            if(DateTime.Compare(p1.vencimiento,p2.vencimiento) > 0)
            {
                retorno = 1;
            }
            else if(DateTime.Compare(p1.vencimiento, p2.vencimiento) < 0)
            {
                retorno = -1;
            }

            return retorno;
        }

        public enum TipoDePrestamo
        {
            Pesos,
            Dolares,
            Todos
        }

        public enum PeriodicidadDePago
        {
            Mensual,
            Bimestral,
            Trimestral
        }
        
    }
}
