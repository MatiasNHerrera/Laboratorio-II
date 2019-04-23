using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesVehiculo
{
    public class Auto : vehiculoPadre
    {
        private int _cantidadAsientos;

        public Auto(int cantidadA,string p, EMarca m, byte c) : base(p, m, c)
        {
            this._cantidadAsientos = cantidadA;
        }
        public string mostrarAuto()
        {
            return "Auto: " + base.mostrarVehiculo() + " - " + this._cantidadAsientos.ToString()+ "\n";
        }
    }
}
