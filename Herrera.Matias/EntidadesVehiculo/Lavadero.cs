using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesVehiculo
{
    public class Lavadero
    {
        private List<vehiculoPadre> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        private Lavadero()
        {
            this._vehiculos = new List<vehiculoPadre>();         
        }

        public Lavadero(float pA, float pC, float pM) : this()
        {
            this._precioAuto = pA;
            this._precioCamion = pC;
            this._precioMoto = pM;
        }


        private string _miLavadero;

        public string MiLavadero
        {
            get
            {
                return "Precio Auto: " + this._precioAuto.ToString() + "\n - Precio Camion: " + this._precioCamion.ToString() + "\n - Precio Moto: " + this._precioMoto.ToString() + "Vehiculos disponibles: " + this.MiLavadero;
            }
        }

        private string _vehiculoProp;

        public string MisVehiculos
        {
            get
            {
                string retorno = "";

                foreach(vehiculoPadre ve in this._vehiculos) //colocar tipo de dato dentro la lista generica, no la lista generica en si
                {
                    if (ve is Auto)
                    {
                        retorno += ((Auto)ve).mostrarAuto();
                    }
                    else if (ve is Moto)
                    {
                        retorno += ((Moto)ve).mostrarMoto();
                    }
                    else
                    {
                        retorno +=((Camion)ve).mostrarCamion();
                    }
                }

                return retorno;
            }
        }

        public static bool operator == (Lavadero l, vehiculoPadre v)
        {
            foreach (vehiculoPadre ve in l._vehiculos)
            {
                if (ve is Auto)
                {
                    
                }
            }
        }

        public static bool operator !=(Lavadero l, vehiculoPadre v)
        {

        }


    }
}
