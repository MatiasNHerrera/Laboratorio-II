using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDeposito
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }


        public string Marca
        {
            get { return this._marca; }
        }

        public string Color
        {
            get { return this._color; }
        }


        public static bool operator ==(Auto a1, Auto a2)
        {
            bool retorno = false;

            if(a1.Color == a2.Color && a1.Marca == a2.Marca)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Auto a1, Auto a2)
        {
            return !(a1 == a2);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Auto)
            {
                if((Auto)obj == this)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public override string ToString()
        {
            return "Color: " + this._color + " - Marca: " + this._marca + "\n";
        }


    }
}
