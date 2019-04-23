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
                return (" - Precio Auto: " + this._precioAuto + "\n - Precio Camion: " + this._precioCamion + "\n - Precio Moto: " + this._precioMoto + "\n\nVehiculos disponibles en el lavadero: \n\n" + this.MisVehiculos).ToString();
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
                    retorno += ve.ToString();     
                }

                return retorno;
            }
        }

        public static bool operator == (Lavadero l, vehiculoPadre v)
        {
            bool retorno = false;

            foreach (vehiculoPadre ve in l._vehiculos)
            {
                 if(ve == v)
                 {
                      retorno = true;
                      break;
                 }
                

                /*else if(ve is Moto)
                {
                    if(ve.MiPatente == v.MiPatente && ve.MiMarca == v.MiMarca)
                    {
                        retorno = true;
                        break;
                    }
                }
                else
                {
                    if(ve.MiPatente == v.MiPatente && ve.MiMarca == v.MiMarca)
                    {
                        retorno = true;
                        break;
                    }
                }*/
    
            }

            return retorno;
        }

        public static bool operator !=(Lavadero l, vehiculoPadre v)
        {
            return !(l == v);
        }

        public static Lavadero operator + (Lavadero l, vehiculoPadre v)
        {
            if (v is Auto)
            {
                if (!(l == v))
                {
                    l._vehiculos.Add(v);
                }
            }
            else if (v is Moto)
            {
                if (!(l == v))
                {
                    l._vehiculos.Add(v);
                }
          
            }
            else
            {
                if (!(l == v))
                {
                    l._vehiculos.Add(v);
                }
            }
           
            return l;
        }

        public static Lavadero operator - (Lavadero l, vehiculoPadre v)
        {
            if (v is Auto)
            {
                if (l == v)
                {
                    l._vehiculos.Remove(v);
                }
            }
            else if (v is Moto)
            {
                if (l == v)
                {
                    l._vehiculos.Remove(v);
                }

            }
            else
            {
                if (l == v)
                {
                    l._vehiculos.Remove(v);
                }
            }

            return l;

        }

        public double MostraTotalFacturado()
        {
            double totalFacturado = 0;
 
            foreach(vehiculoPadre ve in _vehiculos)
            {
               
                if(ve is Auto)
                {
                    totalFacturado += this._precioAuto;
                }
                else if(ve is Moto)
                {
                    totalFacturado += this._precioMoto;
                }
                else
                {
                    totalFacturado += this._precioCamion;
                }
            }

            return totalFacturado;
            
        }

        public double MostrarTotalFacturado(EVehiculo vehiculos)
        {
            double factura= 0;

            foreach(vehiculoPadre ve in _vehiculos)
            {
                if(ve is Auto && vehiculos == EVehiculo.Auto)
                {
                    factura += this._precioAuto;
                }
                else if(ve is Moto && vehiculos == EVehiculo.Moto)
                {
                    factura += this._precioMoto;
                    
                }
                else if (ve is Camion && vehiculos == EVehiculo.Camion)
                {
                    factura += this._precioCamion;
                 
                }
            }

            return factura;

        }


    }
}
