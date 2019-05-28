using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDeposito
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._lista = new List<T>();
            this._capacidadMaxima = capacidad;
        }

        public static bool operator +(Deposito<T> d, T c)
        {
            bool retorno = false;

            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                retorno = true;
            }

            return retorno;
        }

        private int GetIndice(T c)
        {
            int retorno = -1;

            foreach (T co in this._lista)
            {
                if(co.Equals(c))
                {
                    retorno = this._lista.IndexOf(co);
                }
            }

            return retorno;
        }


        public static bool operator -(Deposito<T> d, T c)
        {
            bool retorno = false;

            if (d.GetIndice(c) != -1)
            {
                d._lista.Remove(c);
                retorno = true;
            }

            return retorno;
        }

        public bool Agregar(T c)
        {
            return this + c;
        }

        public bool Remover(T c)
        {
            return this - c;
        }

        public override string ToString()
        {
            string retorno = "";

            retorno += "\nCapacidad disponible: " + this._capacidadMaxima + "\n\n";
            retorno += "*********************\n";
            retorno += "Listado\n";
            retorno += "*********************\n";

            foreach (T c in this._lista)
            {
                retorno += c.ToString();
            }

            return retorno;
        }


    }
}
