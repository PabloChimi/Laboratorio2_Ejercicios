using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        public float InteresesEnDolares
        {
            get
            {
                return CalcularInteresGanado(Prestamo.TipoDePrestamo.Dolares);
            }
        }

        public float InteresesEnPesos
        {
            get
            {
                return CalcularInteresGanado(Prestamo.TipoDePrestamo.Pesos);
            }
        }
        public float InteresesTotales
        {
            get
            {
                return CalcularInteresGanado(Prestamo.TipoDePrestamo.Todos);
            }
        }
        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }
        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }

        
        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial):this()
        {
            this.razonSocial = razonSocial;
        }

        private float CalcularInteresGanado(Prestamo.TipoDePrestamo tipoPrestamo)
        {
            float interesGanado = 0;
            float interesGanadoPesos = 0;
            float interesGanadoDolares = 0;
            float interesGanadoTotal = 0;
            for(int i = 0; i<this.ListaDePrestamos.Count; i++)
            {
                if(this.listaDePrestamos[i] is PrestamoDolar)
                {
                    PrestamoDolar prestamoDolar = (PrestamoDolar)this.listaDePrestamos[i];
                    interesGanadoDolares = interesGanadoDolares + prestamoDolar.Interes;
                    interesGanadoTotal = interesGanadoTotal + prestamoDolar.Interes;
                }
                else if(this.listaDePrestamos[i] is PrestamoPesos)
                {
                    PrestamoPesos prestamoPesos = (PrestamoPesos)this.listaDePrestamos[i];
                    interesGanadoPesos = interesGanadoDolares + prestamoPesos.Interes;
                    interesGanadoTotal = interesGanadoTotal + prestamoPesos.Interes;
                }
            }

            switch(tipoPrestamo)
            {
                case Prestamo.TipoDePrestamo.Dolares:
                    interesGanado = interesGanadoDolares;
                    break;
                case Prestamo.TipoDePrestamo.Pesos:
                    interesGanado = interesGanadoPesos;
                    break;
                case Prestamo.TipoDePrestamo.Todos:
                    interesGanado = interesGanadoTotal;
                    break;
            }
            return interesGanado;

        }

        public void OrdenarPrestamos()
        {
            this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        public static string Mostrar(Financiera financiera)
        {
            return (string) financiera;
        }

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Razon social: {0} || Ganancia por intereses totales: {1} || Ganancia por intereses en pesos: {2} || Ganancias por intereses en dolares: {3}\n\n", financiera.razonSocial, financiera.InteresesTotales, financiera.InteresesEnPesos, financiera.InteresesEnDolares);

            sb.AppendFormat("Detalles de intereses otorgados");
            for (int i = 0; i < financiera.ListaDePrestamos.Count; i++)
            {
                sb.AppendFormat("{0}\n", financiera.ListaDePrestamos[i].Mostrar());
            }
            sb.AppendLine("");
            return sb.ToString();
        }

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            for(int i = 0; i < financiera.listaDePrestamos.Count; i++)
            {
                if(ReferenceEquals(prestamo, financiera.listaDePrestamos[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {
            if(financiera!=prestamoNuevo)
            {
                financiera.listaDePrestamos.Add(prestamoNuevo);
            }
            return financiera;
        }
    }
}
