using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_43
{
    public class Competencia
    {
        public enum TipoCompetencia { F1, MotoCross}
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public short CantidadCompetidores { get; set; }
        public short CantidadVueltas { get; set; }
        public VehiculoDeCarrera this[int i] { get; }
        public TipoCompetencia Tipo { get; set; }

        private Competencia() { }
        public Competencia(short cantVueltas, short cantCompetidores, TipoCompetencia tipo) { }

        public string MostrarDatos() { }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a) { }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a) { }
        public static bool operator +(Competencia c, VehiculoDeCarrera a) { }
        public static bool operator -(Competencia c, VehiculoDeCarrera a) { }
    }
}
