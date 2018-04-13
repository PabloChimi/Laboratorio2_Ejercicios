using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_20_Libreria
{
    public class Dolar
    {
        private double cantidad;
        private float cotizacionRespectoAlDolar;

        private Dolar()
        {
            this.cantidad = 0;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion)
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

        public static explicit operator Pesos(Dolar d)
        {
            Pesos p = new Pesos(0);
            p = new Pesos(d.getCantidad() * p.getCotizacion());
            return p;
        }
        public static explicit operator Euro(Dolar d)
        {
            Euro e = new Euro(0);
            e = new Euro(d.getCantidad() / e.getCotizacion());
            return e;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
    }
}
