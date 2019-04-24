using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herrera.Matias._2ºA.Entidades
{
  public class Grupo
  {
    private List<Mascota> _mascotas;
    private string _nombre;
    private static ETipoManada tipo;

    static Grupo()
    {
      tipo = ETipoManada.Unica;
    }

    private Grupo()
    {
      this._mascotas = new List<Mascota>();
    }

    public Grupo(string nombre) : this()
    {
      this._nombre = nombre;
    }

    public Grupo(string nombre, ETipoManada tipo) : this(nombre)
    {
      this.LaManada = tipo;
    }

    private ETipoManada _miManada;

    public ETipoManada LaManada
    {
      set { tipo = value;}
    }

    public static bool operator == (Grupo grp, Mascota msc)
    {
      bool retorno = false;

      foreach(Mascota mascota in grp._mascotas)
      {
        if(mascota == msc)
        {
          retorno = true;
          break;
        }
      }

      return retorno;
    }

    public static bool operator !=(Grupo grp, Mascota msc)
    {
      return !(grp == msc);
    }

    public static Grupo operator + (Grupo grp, Mascota msc)
    {
      if(!(grp == msc))
      {
        grp._mascotas.Add(msc);
      }
      else
      {
        Console.WriteLine("Ya se encuentra " + msc.ToString() + " en el grupo");
      }

      return grp;
    }

    public static Grupo operator - (Grupo grp, Mascota msc)
    {
      if(grp == msc)
      {
        grp._mascotas.Remove(msc);
      }
      else
      {
        Console.WriteLine("\nNo se encuentra " + msc.ToString() + " en el grupo");
      }

      return grp;
    }

    public static implicit operator string(Grupo g)
    {
      string retorno = "";
      int count = 0;

      count = g._mascotas.Count();
      retorno = "Grupo: " + g._nombre + " - " + "Tipo: " + tipo + "\n" + "Cantidad de integrantes:  " + count;
      foreach (Mascota masc in g._mascotas)
      {
        retorno +=  "\n" + masc.ToString();
      }

      return retorno;
    }

  }
}
