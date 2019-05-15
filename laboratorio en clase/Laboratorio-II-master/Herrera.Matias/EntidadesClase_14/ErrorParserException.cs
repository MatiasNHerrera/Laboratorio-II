using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase_14
{
  public class ErrorParserException : Exception
  { 
    public ErrorParserException(string mensaje, Exception inner) : base(mensaje, inner)
    {
        
    }
  }
}
