using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela : Libro
    {
        private EGenero genero;

        public Novela(string titulo, float precio, Autor autor, EGenero genero) : base(titulo, autor, precio)
        {
            this.genero = genero;
        }

        public string Mostrar()
        {
            return (string)this + "\nGENERO: " + this.genero + "\n";
        }

        public static bool operator ==(Novela n1, Novela n2)
        {
            bool retorno = false;

            if (n1.genero == n2.genero && ((Libro)n1) == ((Libro)n2))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Novela n1, Novela n2)
        {
            return !(n1 == n2);
        }

        public static implicit operator double(Novela n)
        {
            return n._precio;
        }
    }
}
