using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_37
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            return Duracion * GetFranjaValue(this.franjaHoraria);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Caracteristicas llamada: {0} \n Franja horaria: {1} Costo llamada: {2} \n", base.Mostrar(), this.franjaHoraria, this.CostoLlamada);
            return sb.ToString();
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }
        
        public float GetFranjaValue(Franja franja)
        {
            float retorno;
            switch (franja)
            {
                case Franja.Franja_1:
                    {
                        retorno = (float)0.99;
                        break;
                    }
                case Franja.Franja_2:
                    {
                        retorno = (float)1.25;
                        break;
                    }
                case Franja.Franja_3:
                    {
                        retorno = (float)0.66;
                        break;
                    }
                default:
                    {
                        retorno = 0;
                        break;
                    }
            }
            return retorno;
        }
    }
}
