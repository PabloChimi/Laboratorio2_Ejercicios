using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_41b
{
    public class Centralita
    {
        #region atributos

        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #endregion

        #region propiedades

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        #endregion

        #region constructores

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #endregion

        #region metodos

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaTotal = 0;
            float gananciaLocal = 0;
            float gananciaProvincial = 0;
            float retorno = 0;
            int i;

            for (i = 0; i < this.Llamadas.Count; i++)
            {
                if (this.Llamadas[i] is Local)
                {
                    Local local = (Local)this.Llamadas[i];
                    gananciaLocal = local.CostoLlamada + gananciaLocal;
                    gananciaTotal = local.CostoLlamada + gananciaTotal;
                }
                else
                {
                    Provincial provincial = (Provincial)this.Llamadas[i];
                    gananciaProvincial = provincial.CostoLlamada + gananciaProvincial;
                    gananciaTotal = provincial.CostoLlamada + gananciaTotal;
                }
            }

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    {
                        retorno = gananciaLocal;
                        break;
                    }
                case Llamada.TipoLlamada.Provincial:
                    {
                        retorno = gananciaProvincial;
                        break;
                    }
                case Llamada.TipoLlamada.Todas:
                    {
                        retorno = gananciaTotal;
                        break;
                    }
            }
            return retorno;
        }

        public void OrdenarLlamada()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Razon social: {0} || Ganancia por llamados locales: {1} || Ganancia por llamados provinciales: {2} || Ganancias totales: {3}\n\n", this.razonSocial, this.GananciasPorLocal, this.GananciasPorProvincial, this.GananciasPorTotal);

            //sb.Append("<span style=\"background-color:Blue;\">");

            sb.AppendFormat("Detalles de llamadas realizadas\n");
            for (int i = 0; i < this.Llamadas.Count; i++)
            {
                sb.AppendFormat("{0}\n", this.Llamadas[i].ToString());
                /*if (this.Llamadas[i] is Local)
                {
                    Local local = (Local)this.Llamadas[i];
                    sb.AppendFormat("Llamada local--> {0}", this.To.());
                }
                else
                {
                    Provincial provincial = (Provincial)this.Llamadas[i];
                    sb.AppendFormat("Llamada provincial--> {0}", this.Mostrar());
                }*/
            }
            sb.AppendLine("");
            return sb.ToString();
        }

        #endregion

        #region sobrecarga de metodos

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion

        #region sobrecarga de operadores

        public static Centralita operator +(Centralita c, Llamada l)
        {
            if (c != l)
            {
                c.AgregarLlamada(l);
            }
            else
            {
                throw new CentralitaExcepcion("Llamada ya registrada", "Centralita", "Operator +");
            }
            return c;
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            for (int i = 0; i < c.Llamadas.Count; i++)
            {
                if (c.Llamadas[i] == l)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        #endregion
    }
}
