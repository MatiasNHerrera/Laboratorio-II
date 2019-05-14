using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase_14
{
  public static class ParseadoraDeEnteros
  {

    public static bool TryParse(string s, out int i)
    {
      bool validacion = false;
      i = 0;

      try
      {
        i = Int32.Parse(s);
        validacion = true;
      }

      catch (Exception e)
      {
        validacion = false;
      }

      return validacion;

    }

    public static int Parse(string s)
    {
      int retorno = 0;

      try
      {
        retorno = Int32.Parse(s);
      }
      catch (FormatException e)
      {
        throw new ErrorParserException("el string no podra ser convertido - ", e);
      }
      catch (OverflowException e)
      {
        throw new ErrorParserException("el string no podra ser convertido - ", e);
      }

      return retorno;
      
    }

  }
}
