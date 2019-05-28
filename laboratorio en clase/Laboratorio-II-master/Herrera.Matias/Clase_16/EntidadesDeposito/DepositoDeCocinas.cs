using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDeposito
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._lista = new List<Cocina>();
            this._capacidadMaxima = capacidad;
        }

        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;

            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                retorno = true;
            }

            return retorno;
        }

        private int GetIndice(Cocina c)
        {
            int retorno = -1;

            foreach (Cocina co in this._lista)
            {
                if (co == c)
                {
                    retorno = this._lista.IndexOf(co);
                }
            }

            return retorno;
        }


        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;

            if (d.GetIndice(c) != -1)
            {
                d._lista.Remove(c);
                retorno = true;
            }

            return retorno;
        }

        public bool Agregar(Cocina c)
        {
            return this + c;
        }

        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public override string ToString()
        {
            string retorno = "";

            retorno += "\nCapacidad disponible: " + this._capacidadMaxima + "\n\n";
            retorno += "*********************\n";
            retorno += "Listado de Cocinas\n";
            retorno += "*********************\n";

            foreach(Cocina c in this._lista)
            {
                retorno += c.ToString();
            }

            return retorno;
        }


    }
}
