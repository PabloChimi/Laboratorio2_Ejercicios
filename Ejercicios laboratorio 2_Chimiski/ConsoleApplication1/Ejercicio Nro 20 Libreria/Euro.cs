using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_20
{
    class Euro
    {
        private double cantidad;
        private float cotizacionRespectoAlDolar;

        private Euro()
        {
            this.cantidad = 0;
            this.cotizacionRespectoAlDolar = float.Parse("1.3642");
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
            this.cotizacionRespectoAlDolar = float.Parse("1.3642");
        }

        public Euro(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            this.cotizacionRespectoAlDolar = cotizacion;
        }

        public float getCotizacion()
        {
            return this.cotizacionRespectoAlDolar;
        }

        public double getCantidad()
        {
            return this.cantidad;
        }

        public static explicit operator Pesos(Euro e)
        {
            Pesos p = new Pesos(0);
            float cotizacion = p.getCotizacion() / e.getCotizacion();
            p = new Pesos(e.getCantidad() / cotizacion);
            return p;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * e.cotizacionRespectoAlDolar);            
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
    }
}
