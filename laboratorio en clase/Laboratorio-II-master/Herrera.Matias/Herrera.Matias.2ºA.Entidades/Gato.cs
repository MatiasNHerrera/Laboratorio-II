using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herrera.Matias._2ºA.Entidades
{
  public class Gato : Mascota
  {

    public Gato(string nombre, string raza) : base(nombre, raza)
    {

    }

    protected override string ficha()
    {
      return base.DatosCompletos();
    }

    public static bool operator == (Gato g1, Gato g2)
    {
      bool retorno = false;

      if(g1.MascotaNombre == g2.MascotaNombre && g1.RazaMascota == g2.RazaMascota)
      {
        retorno = true;
      }

      return retorno;
    }

    public static bool operator !=(Gato g1, Gato g2)
    {
      return !(g1 == g2); 
    }

    public override string ToString()
    {
      return this.ficha();
    }

    public override bool Equals(object obj)
    {
      bool retorno = false;

      if(obj is Gato)
      {
        retorno = this == obj;
      }
      else
      {
        retorno = false;
      }

      return retorno;
    }


  }
}
