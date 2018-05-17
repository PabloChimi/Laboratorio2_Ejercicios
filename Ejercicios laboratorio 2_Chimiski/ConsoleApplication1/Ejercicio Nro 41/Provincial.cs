using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_41
{
    public class Provincial : Llamada
    {
        #region atributos

        protected Franja franjaHoraria;

        #endregion

        #region propiedades
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion

        #region constructores

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
        #endregion

        #region metodos

        private float CalcularCosto()
        {
            return Duracion * GetFranjaValue(this.franjaHoraria);
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
        #endregion

        #region sobrecarga de metodos

        public override bool Equals(object obj)
        {
            if (obj is Provincial)
            {
                return true;
            }
            return false;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Franja horaria: {1,5} Costo llamada: {2,4}", base.Mostrar(), this.franjaHoraria, this.CostoLlamada);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion

        #region enumeraciones

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }

        #endregion

    }
}
