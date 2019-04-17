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

        public string mostrarCamion()
        {
            return base.mostrarVehiculo() + " - " + this._tara.ToString();
        }
    }
}
