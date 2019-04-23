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
    /*public string mostrarMoto()
    {
        return "Moto: " + base.mostrarVehiculo() + " - " + this._cilindrada.ToString() + "\n";
    }*/

       public override string ToString()
       {
          return "Moto: " + base.ToString() + " - " + this._cilindrada + "\n";
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
