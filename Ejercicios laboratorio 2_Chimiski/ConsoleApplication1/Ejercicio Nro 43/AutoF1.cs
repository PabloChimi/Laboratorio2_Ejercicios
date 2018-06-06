using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_43
{
    public class AutoF1:VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza { get; set; }

        public AutoF1(short numero, string escuderia):base(numero,escuderia) { }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia) { }

        public override string MostrarDatos()
        {
            return base.MostrarDatos();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2) { }
        public static bool operator !=(AutoF1 a1, AutoF1 a2) { }
    }
}
