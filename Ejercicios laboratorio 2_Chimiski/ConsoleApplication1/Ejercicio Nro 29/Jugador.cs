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
            this.dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(string nombre)
        {
            this.dni = 0;
            this.nombre = nombre;
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(string nombre, int totalGoles, int totalPArtidos)
        {
            this.dni = 0;
            this.nombre = nombre;
            this.partidosJugados = totalPArtidos;
            this.promedioGoles = 0;
            this.totalGoles = totalGoles;

    }
}
