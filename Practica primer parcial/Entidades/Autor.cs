using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        private string nombre;
        private string apellido;

        public Autor(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static bool operator == (Autor a1, Autor a2)
        {
            bool retorno = false;

            if(a1.nombre == a2.nombre && a1.apellido == a2.apellido)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Autor a1, Autor a2)
        {
            return !(a1 == a2);
        }

        public static implicit operator string (Autor a)
        {
            return a.nombre + " | " + a.apellido;
        }



    }
}
