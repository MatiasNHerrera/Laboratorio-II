using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herrera.Matias._2ºA.Entidades
{
  public abstract class Mascota
  {
    private string _raza;
    private string _nombre;

    private string _MascotaNombre;

    public string MascotaNombre
    {
      get { return this._nombre; }
    }

    private string _RazaMascota;

    public string RazaMascota
    {
      get { return this._raza; }
    }

    public Mascota(string nombre, string raza)
    {
      this._raza = raza;
      this._nombre = nombre;
    }

    protected virtual string DatosCompletos()
    {
      return "Nombre: " + this._nombre + " - Raza: " + this._raza;
    }

    protected abstract string ficha(); 
    

  }
}
