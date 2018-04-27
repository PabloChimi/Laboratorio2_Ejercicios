using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_37
{
    public class Local : Llamada
    {
        #region atributos

        protected float costo;

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

        #region Constructores

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        #endregion

        #region metodos

        private float CalcularCosto()
        {
            return this.costo * Duracion;
        }

        #endregion

        #region sobrecarga metodos

        public override bool Equals(object obj)
        {
            if (obj is Local)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Costo llamada: {1,4}", base.Mostrar(), this.CostoLlamada);
            return sb.ToString();
        }
        #endregion
    }
}
