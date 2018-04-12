using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_16
{
    class Alumno
    {
        public string nombre;
        public string apellido;
        public int legajo;
        private byte nota1;
        private byte nota2;
        private float notaFinal;

        public void Estudiar(byte primerNota, byte segundaNota)
        {
            this.nota1 = primerNota;
            this.nota2 = segundaNota;
        }

        public void CalcularFinal()
        {
            if (nota1 >= 4 && nota2 >= 4)
            {
                Random r = new Random();
                notaFinal = r.Next(0, 10);
            }
            else
            {
                notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            string retorno;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0,20}", this.legajo);
            sb.AppendFormat("{0,20}", this.apellido);
            sb.AppendFormat("{0,20}", this.nombre);
            retorno = sb.ToString();
            return retorno;
        }
    }
}
