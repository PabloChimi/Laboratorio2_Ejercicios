using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_29
{
    class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {

            Random rnd = new Random();
            this.dni = rnd.Next(1, 50000000);
            this.nombre = "";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Jugador(string nombre, int totalGoles, int totalPArtidos) : this()
        {
            this.nombre = nombre;
            this.partidosJugados = totalPArtidos;
            this.totalGoles = totalGoles;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
