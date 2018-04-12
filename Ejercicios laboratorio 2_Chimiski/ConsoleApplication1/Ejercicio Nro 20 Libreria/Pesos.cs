using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_20
{
    class Pesos
    {
        private double cantidad;
        private float cotizacionRespectoAlDolar;

        private Pesos()
        {
            this.cantidad = 0;
            this.cotizacionRespectoAlDolar = float.Parse("0.0569");
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
            this.cotizacionRespectoAlDolar = float.Parse("0.0569");
        }

        public Pesos(double cantidad, float cotizacion)
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

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.getCantidad() * p.getCotizacion());

        }
        public static explicit operator Euro(Pesos p)
        {
            Euro e = new Euro(0);
            float cotizacion = p.getCotizacion() / e.getCotizacion();
            e = new Euro(e.getCantidad() * cotizacion);
            return e;
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        
    }
}
