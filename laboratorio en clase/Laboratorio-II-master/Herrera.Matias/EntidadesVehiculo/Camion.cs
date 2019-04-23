using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesVehiculo
{
    public class Camion : vehiculoPadre
    {
        private double _tara;

        public Camion(string p, EMarca m, byte c, double t) : base(p, m, c)
        {
            this._tara = t;
        }

    /*public string mostrarCamion()
    {
        return "Camion: " + base.mostrarVehiculo() + " - " + this._tara.ToString() + "\n";
    }*/

    public override string ToString()
    {
      return "Camion: " + base.ToString() + " - " + this._tara.ToString() + "\n";
    }

    public override double MiPrecio
    {
      get;
      set;
    }

    public override double CalcularPrecioConIva()
    {
      return this.MiPrecio * 1.21;
    }
  }
}
