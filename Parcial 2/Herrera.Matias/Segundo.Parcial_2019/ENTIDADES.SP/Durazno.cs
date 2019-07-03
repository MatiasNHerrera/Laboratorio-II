using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
    public class Durazno : Fruta
    {
        protected int _cantPelusa;

        public Durazno(string color, double peso, int cantidadPelusa) : base(color, peso)
        {
            this._cantPelusa = cantidadPelusa;
        }

        public String Nombre
        {
            get
            {
                return "Durazno";
            }
        }

        public override string ToString()
        {
            return base.FrutaToString() + "Cantidad Pelusa: " + this._cantPelusa;
        }

        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }
    }
}
