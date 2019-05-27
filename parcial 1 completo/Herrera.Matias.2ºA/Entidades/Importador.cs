using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
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
            return (string)this + "Pais Origen: " + this.paisOrigen + "\n\n";
        }

        public static bool operator == (Importador i1, Importador i2)
        {
            bool retorno = false;

            if(i1.paisOrigen == i2.paisOrigen && ((Comercio)i1) == ((Comercio)i2))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Importador i1, Importador i2)
        {
            return !(i1 == i2);
        }

        public static implicit operator float(Importador i1)
        {
            return i1._precioAlquiler;
        }
    }
}
