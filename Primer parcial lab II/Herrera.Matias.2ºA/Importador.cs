using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herrera.Matias._2ºA
{
    public class Importador : Comercio
    {
        public EPaises paisOrigen;

        public Importador(string nombreComercio, float precioAlquiler, Comerciante comerciante, EPaises paisOrigen) : base(nombreComercio, comerciante, precioAlquiler)
        {
            this.paisOrigen = paisOrigen;
        }

        public string Mostrar()
        {
            return (string)base._comerciante + " -Pais Origen: " + this.paisOrigen;
        }

        public static bool operator ==(Importador i1, Importador i2)
        {
            bool retorno = false;

            if(i1.paisOrigen == i2.paisOrigen && i1._nombre == i2._nombre)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Importador i1, Importador i2)
        {
            return !(i1 == i2);
        }

        public static implicit operator double(Importador i)
        {
            return i._precioAlquiler;
        }




    }
}
