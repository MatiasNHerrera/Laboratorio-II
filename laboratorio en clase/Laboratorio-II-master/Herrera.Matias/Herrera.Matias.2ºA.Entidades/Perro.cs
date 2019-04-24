using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herrera.Matias._2ºA.Entidades
{
  public class Perro : Mascota
  {
    private int edad;
    private bool esAlfa;

    public Perro(string nombre, string raza) : base(nombre, raza)
    {
      this.edad = 0;
      this.esAlfa = false;
    }

    public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
    {
      this.edad = edad;
      this.esAlfa = esAlfa;
    }

    protected override string ficha()
    {
      string retorno = "";

      if(this.esAlfa == true)
      {
        retorno = base.DatosCompletos() + " - " + "Es alfa y su edad es: " + this.edad; 
      }
      else
      {
        retorno = base.DatosCompletos() + " - " + "su edad es: " + this.edad;
      }

      return retorno;
    }

    public static bool operator == (Perro p1, Perro p2)
    {
      bool retorno = false;

      if(p1.edad == p2.edad && p1.MascotaNombre == p2.MascotaNombre && p1.RazaMascota == p2.RazaMascota)
      {
        retorno = true;
      }

      return retorno;
    }

    public static bool operator !=(Perro p1, Perro p2)
    {
      return !(p1 == p2);
    }

    public static explicit operator int(Perro p)
    {
      return p.edad;
    }

    public override string ToString()
    {
      return this.ficha();
    }

    public override bool Equals(object obj)
    {
      bool retorno = false;

      if(obj is Perro)
      {
        retorno =  this == obj;
      }
      else
      {
        retorno = false;
      }

      return retorno;
    }


  }
}
