using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesVehiculo
{
    public class vehiculoPadre
    {
        private string _patente;
        private EMarca _marca;
        private byte _cantidadRuedas;

        public vehiculoPadre(string p, EMarca m, byte c)
        {
            this._patente = p;
            this._marca = m;
            this._cantidadRuedas = c;
        }

        protected string mostrarVehiculo()
        {
            return this._patente + " - " + this._marca + " - " + this._cantidadRuedas.ToString();
        }


        public static bool operator + (vehiculoPadre auxUno, vehiculoPadre auxDos)
        {
            bool retorno = false;

            if(auxUno._patente == auxDos._patente && auxUno._marca == auxDos._marca)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
