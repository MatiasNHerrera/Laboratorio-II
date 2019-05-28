using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDeposito
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _listado;

        public DepositoDeAutos(int capacidad)
        {
            _listado = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }

        public static bool operator + (DepositoDeAutos d, Auto a)
        {
            bool retorno = false;

            if(d._listado.Count < d._capacidadMaxima)
            {
                d._listado.Add(a);
                retorno = true;
            }

            return retorno;
        }

        private int GetIndice(Auto a)
        {
            int retorno = -1;

            foreach(Auto au in this._listado)
            {
                if(au == a)
                {
                    retorno = this._listado.IndexOf(au);
                }
            }

            return retorno;
        }


        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;

            if(d.GetIndice(a) != -1)
            {
                d._listado.Remove(a);
                retorno = true;
            }
            
            return retorno;
        }

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string retorno = "";

            retorno += "La capacidad es: " + this._capacidadMaxima.ToString() + "\n\n";
            retorno += "*******************\n";
            retorno += "Listado de autos\n";
            retorno += "*******************\n";

            foreach(Auto a in this._listado)
            {
                retorno += a.ToString();
            }

            return retorno;
        }

    }
}
