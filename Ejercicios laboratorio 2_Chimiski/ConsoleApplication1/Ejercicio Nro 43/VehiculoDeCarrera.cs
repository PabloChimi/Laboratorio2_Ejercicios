using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_43
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible { get; set; }
        public bool EnCompetencia { get; set; }
        public string Escuderia { get; set; }
        public short Numero { get; set; }
        public short VueltasRestantes { get; set; }

        public VehiculoDeCarrera(short numero, string escuderia) { }
        public virtual string MostrarDatos() { }
        
    }
}
