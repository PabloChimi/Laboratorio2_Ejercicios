using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_32
{
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return c.competidores.Contains(a);
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if((c != a) && (c.competidores.Count < c.cantidadCompetidores))
            {
                Random rnd = new Random();
                a.EnCompetencia= true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short) rnd.Next(15, 100);
                c.competidores.Add(a);
                return true;
            }
            return false;
        }


    }
}
