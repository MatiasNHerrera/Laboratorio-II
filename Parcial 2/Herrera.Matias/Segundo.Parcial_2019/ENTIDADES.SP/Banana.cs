using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
    public class Banana : Fruta
    {
        protected string _paisOrigen;

        public Banana(string color, double peso, string origen) : base(color, peso)
        {
            this._paisOrigen = origen;
        }

        public string Nombre
        {
            get
            {
                return "banana";
            }
        }

        public override string ToString()
        {
            return base.FrutaToString() + "Origen: " + this._paisOrigen;
        }

        public override bool TieneCarozo
        {
            get
            {
                return false;
            }
        }
    }
}
