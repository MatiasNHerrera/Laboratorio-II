using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_05.Entidades
{
    public class Paleta
    {
        private Tempera[] _temperas;
        private int _cantidadMax;

        private Paleta(int cantidadMaxima)
        {
            this._cantidadMax = cantidadMaxima;
            _temperas = new Tempera[cantidadMaxima];
        }

        private Paleta() : this(5)
        {

        }

        public static implicit operator Paleta(int cantidad)
        {
            Paleta objRetorno = new Paleta(cantidad);

            return objRetorno;
        }

        private string Mostrar()
        {
            string retorno = "";

            retorno = "la cantidad maxima es: " + this._cantidadMax.ToString();

            foreach(Tempera t in this._temperas)
            {
                 retorno += "\n" + Tempera.Mostrar(t);  // Foreach va guardando las temperas en la variable t, _temperas es el array a recorrer.
            }

            return retorno;
            
        }

        public static explicit operator string (Paleta mostrarExplicito)
        {
            return mostrarExplicito.Mostrar();
        }

        


    }
}
