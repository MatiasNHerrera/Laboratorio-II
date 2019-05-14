using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herrera.Matias._2ºA
{
    public class Shopping
    {
        private int capacidad;
        private List<Comercio> comercios;

        private Shopping()
        {
            this.comercios = new List<Comercio>();
        }

        private Shopping(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public string Mostrar(Shopping s)
        {
            string retorno = "";

            foreach(Comercio c in s.comercios)
            {
                retorno += (string)c;
            }

            return retorno;
        }

        public static implicit operator Shopping(int capacidad)
        {
            Shopping nuevo = new Shopping(capacidad);

            if(nuevo.capacidad == capacidad)
            {
                nuevo.capacidad = capacidad;
            }

            return nuevo;
        }

        public static bool operator ==(Shopping s1, Comercio c)
        {
            bool retorno = false;

            foreach(Comercio co in s1.comercios)
            {
                if(co == c)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Shopping s1, Comercio c)
        {
            return !(s1 == c);
        }

        public static Shopping operator +(Shopping s1, Comercio c)
        {
            if(!(s1 == c) && s1.comercios.Count < s1.capacidad)
            {
                s1.comercios.Add(c);
            }
            else
            {
                Console.WriteLine("\nNo pudo agregarse el comercio\n");
            }

            return s1;
        }

        



    }
}
