using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual : Libro
    {
        private ETipo tipo;

        public Manual(string titulo, float precio, string nombre, string apellido, ETipo tipo) : base(precio,titulo,nombre,apellido)
        {
            this.tipo = tipo;
        }

        public string Mostrar()
        {
            return (string)this + "\nTIPO: " + this.tipo + "\n";
        }

        public static bool operator == (Manual m1, Manual m2)
        {
            bool retorno = false;

            if(m1.tipo == m2.tipo && ((Libro)m1) == ((Libro)m2))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Manual m1, Manual m2)
        {
            return !(m1 == m2);
        }

        public static implicit operator double(Manual m)
        {
            return m._precio;
        }
    }
}
