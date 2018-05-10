using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera
{
 public class PrestamoPesos:Prestamo
    {
        private float porcentajeInteres;

        public float Interes
        {
            get
            {
                return CalcularInteres();
            }
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes):base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres):base(prestamo.Monto, prestamo.Vencimiento)
        {
            this.porcentajeInteres = porcentajeInteres;
        }

        private float CalcularInteres()
        {
            return porcentajeInteres * this.monto;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            float incrementoInteres = (float)0.25;
            if ((nuevoVencimiento - this.Vencimiento).Days > 0)
            {
                this.porcentajeInteres = (nuevoVencimiento - this.Vencimiento).Days * incrementoInteres + this.porcentajeInteres;
            }

            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Porcentaje del interes: {1,4}", base.Mostrar(), this.porcentajeInteres);
            return sb.ToString();
        }


    }
}
