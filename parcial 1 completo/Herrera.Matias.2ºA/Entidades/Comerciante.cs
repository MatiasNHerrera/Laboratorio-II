using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comerciante
    {
        private string apellido;
        private string nombre;

        public Comerciante(string nombre, string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public static bool operator ==(Comerciante c1, Comerciante c2)
        {
            bool retorno = false;

            if(c1.nombre == c2.nombre && c1.apellido == c2.apellido)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Comerciante c1, Comerciante c2)
        {
            return !(c1 == c2);
        }

        public static implicit operator string(Comerciante c)
        {
            return "Nombre: " + c.nombre + " - Apellido: " + c.apellido;
        }


    }
}
