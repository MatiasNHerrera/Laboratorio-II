using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_05.Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipoTinta;


        public Tinta() : this(ETipoTinta.Comun, ConsoleColor.Black)
        {

        }

        public Tinta(ConsoleColor color) : this(ETipoTinta.Comun, color)
        {

        }

        public Tinta(ETipoTinta tinta, ConsoleColor color)
        {
            this._tipoTinta = tinta;
            this._color = color;
        }

        private string Mostrar()
        {
            return this._color.ToString() + "-" + this._tipoTinta.ToString();
        }

        public static string Mostrar(Tinta laTinta)
        {
            return laTinta.Mostrar();
        }

        public static bool operator == (Tinta obj1Comp, Tinta obj2Comp)
        {
            bool respuesta = false;

            if(obj1Comp._color == obj2Comp._color && obj1Comp._tipoTinta == obj2Comp._tipoTinta)
            {
                respuesta = true;
            }

            return respuesta;
        }

        public static bool operator !=(Tinta obj1Comp, Tinta obj2Comp)
        {
            return !(obj1Comp == obj2Comp);
        }
    }
}
