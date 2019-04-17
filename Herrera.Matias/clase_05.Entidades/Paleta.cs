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

        private Tempera[] MisTemperas;

        public Tempera[] _MisTemperas
        {
            get { return _temperas; }
        }


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

        public static bool operator == (Paleta pal, Tempera tem)
        {
            bool retorno = false;

            foreach (Tempera t in pal._temperas)
            {
                if (t == tem)
                {
                    retorno = true;
                }

            }

            return retorno;

        }

        public static bool operator !=(Paleta pal, Tempera tem)
        {
            return !(pal == tem);
        }

        public static Paleta operator + (Paleta pal, Tempera tem)
        {
            if (!(pal == tem))
            {
                pal._temperas[pal.ObtenerIndice()] = tem;
            }

            return pal;
        }

        public static Paleta operator -(Paleta auxUno, Tempera auxDos)
        {
            int i = -1;

            foreach (Tempera t in auxUno._MisTemperas)
            {
                i++;
                if (t == auxDos)
                {        
                    auxUno._MisTemperas[i] = null;
                    break;
                }           
            }
                 return auxUno;

        }

        private int ObtenerIndice()
        {
            int indice = -1;
            int i = -1;

            foreach (Tempera t in _temperas)
            {
                    i++;
                    if(object.Equals(t,null))
                    {
                        indice = i;
                        break;
                    }
            }

            return indice;
        }



    }
}
