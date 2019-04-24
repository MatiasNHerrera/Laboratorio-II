using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesVehiculo
{
    //mi clase abstracta nunca va a poder generar instancia de ellas, es decir objetos
    //Puede contener metodos y propiedades abstractas: pero de estos solo puedo poseer la firma, no la implementacion

    public abstract class vehiculoPadre 
    {
        protected string _patente;
        protected EMarca _marca;
        protected byte _cantidadRuedas;

        public vehiculoPadre(string p, EMarca m, byte c)
        {
            this._patente = p;
            this._marca = m;
            this._cantidadRuedas = c;
        }

        /*protected string mostrarVehiculo()
        {
            return this._patente + " - " + this._marca + " - " + this._cantidadRuedas.ToString();
        }*/

        private string _miPatente;

        public string MiPatente
        {
            get { return this._patente; }
        }

        private EMarca _miMarca;

        public EMarca MiMarca
        {
            get { return this._marca; }
        }

        public static bool operator == (vehiculoPadre auxUno, vehiculoPadre auxDos)
        {
            bool retorno = false;

            if(auxUno._patente == auxDos._patente && auxUno._marca == auxDos._marca)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(vehiculoPadre auxUno, vehiculoPadre auxDos)
        {
            return !(auxUno == auxDos);
        }


        public override string ToString()
        {
          return this._patente + " - " + this._marca + " - " + this._cantidadRuedas.ToString();
        }

        private double _precio;

        public abstract double MiPrecio
        {
          get;
          set;
        }

        public abstract double CalcularPrecioConIva();

  }
}
