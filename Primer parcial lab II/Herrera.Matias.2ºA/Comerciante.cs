using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herrera.Matias._2ºA
{
    public class Comerciante
    {
        private string apellido;
        private string nombre;

        public Comerciante(string apellido, string nombre)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static bool operator == (Comerciante a, Comerciante b)
        {
            bool retorno = false;

            if(a.apellido == b.apellido && a.nombre == b.nombre)
            {
                retorno = true;
            }

            return retorno;

        }

        public static bool operator !=(Comerciante a, Comerciante b)
        {
            return !(a == b);
        }

        public static implicit operator string(Comerciante a)
        {
            return a.nombre + a.apellido;
        }





    }
}
