using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extensora
    {
        public static bool esPar(this Int32 numero)
        {
            bool retorno = false;

            if(numero % 2 == 0)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool esImpar(this Int32 numero)
        {
            bool retorno = false;
                
            if(numero % 2 != 0)
            {
                retorno = true;
            }

            return retorno;
            
        }
    }
}
