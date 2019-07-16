using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CantidadMaximaException : Exception
    {
        public CantidadMaximaException(string mensaje) : base(mensaje)
        {

        }
    }
}
