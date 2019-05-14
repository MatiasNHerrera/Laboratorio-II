using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesClase_14;

namespace testException_clase14
{
  class Program
  {
    static void Main(string[] args)
    {
      int i;

      try
      {
        ParseadoraDeEnteros.Parse("455555535353");
      }
      catch(ErrorParserException e)
      {
        Console.WriteLine(e.Message + e.InnerException.Message);
      }

      if(ParseadoraDeEnteros.TryParse("sdsadsadasd", out i))
      {
        Console.WriteLine("\nSe parsear");
      }
      else
      {
        Console.WriteLine("\nNo se pudo parsear");
      }

      Console.ReadKey();
      
    }
  }
}
