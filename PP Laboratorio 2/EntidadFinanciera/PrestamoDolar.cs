using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera
{
    public class PrestamoDolar:Prestamo
    {
        private PeriodicidadDePago periodicidad;

        public float Interes
        {
            get
            {
                return CalcularInteres();
            }
        }
        public PeriodicidadDePago Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
        }
        
        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePago periodicidad):base(monto,vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePago periodicidad):base(prestamo.Monto, prestamo.Vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        private float CalcularInteres()
        {
            float prestamoTotal = this.Monto;
            float interes = 0;

            switch(this.Periodicidad)
            {
                case PeriodicidadDePago.Mensual:
                    {
                        interes = (float) 0.25;
                        prestamoTotal = prestamoTotal + prestamoTotal * interes;
                        break;
                    }
                case PeriodicidadDePago.Bimestral:
                    {
                        interes = (float)0.35;
                        prestamoTotal = prestamoTotal + prestamoTotal * interes;
                        break;
                    }
                case PeriodicidadDePago.Trimestral:
                    {
                        interes = (float)0.4;
                        prestamoTotal = prestamoTotal + prestamoTotal * interes;
                        break;
                    }
            }
            return prestamoTotal;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            float aumentoPorDia = (float)2.5;
            if ((nuevoVencimiento - this.Vencimiento).Days > 0)
            {
                this.monto = (nuevoVencimiento - this.Vencimiento).Days*aumentoPorDia + this.Monto;
            }

            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Periodicidad del prestamo: {1,10}", base.Mostrar(), this.Periodicidad);
            return sb.ToString();
        }

    }
}
