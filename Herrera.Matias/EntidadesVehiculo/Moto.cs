using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesVehiculo
{
    public class Moto : vehiculoPadre
    {
        private double _cilindrada;

        public Moto(double cilin, string p, EMarca m, byte c) : base(p, m, c)
        {
            this._cilindrada = cilin;
        }
        public string mostrarMoto()
        {
            return base.mostrarVehiculo() + " - " + this._cilindrada.ToString();
        }
    }
}
