using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;

namespace Entidades.Alumnos
{
  public static class Extensora
  {
    public static string ExtensionNombre(this PersonaExternaSellada persona)
    {
      return persona.Apellido;
    }
  }
}
