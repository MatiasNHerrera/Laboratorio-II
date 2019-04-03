using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_05.Entidades
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;


        public Pluma(string marca, int cantidad, Tinta tinta)
        {
            this._marca = marca;
            this._cantidad = cantidad;
            this._tinta = tinta;
        }

        public Pluma(int cantidad, Tinta tinta) : this("sin marca", cantidad, tinta)
        {

        }

        public Pluma(Tinta tinta) : this("sin marca", 0, tinta)
        {

        }

        public Pluma() : this("sin marca", 0, null)
        {

        }

        private string Mostrar()
        {
            return (this._marca).ToString() + "-" + (this._cantidad).ToString() + "-" + Tinta.Mostrar(this._tinta);
        }

        public static bool operator ==(Pluma obj1Comp, Tinta obj2Comp)
        {
            return obj1Comp._tinta == obj2Comp;
        }

        public static bool operator !=(Pluma obj1Comp, Tinta obj2Comp)
        {
            return !(obj1Comp == obj2Comp);
        }

        public static implicit /*o explicit*/ operator string (Pluma p)
        {
            return p.Mostrar();
        }

        public static Pluma operator + (Pluma p, Tinta t)
        {
            if(p._cantidad < 91 && p == t)
            {
                p._cantidad = p._cantidad + 10;
            }

            return p;
        }

        


    }
}
