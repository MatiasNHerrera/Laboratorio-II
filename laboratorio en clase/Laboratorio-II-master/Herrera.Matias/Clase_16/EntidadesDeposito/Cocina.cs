using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDeposito
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustria;
        private double _precio;
        

        public Cocina(int codigo, double precio, bool esIndustria)
        {
            this._codigo = codigo;
            this._esIndustria = esIndustria;
            this._precio = precio;
        }

        public int Codigo
        {
            get { return this._codigo; }
        }

        public bool EsIndustria
        {
            get { return this._esIndustria; }
        }

        public double Precio
        {
            get { return this._precio; }
        }

        public static bool operator ==(Cocina c1, Cocina c2)
        {
            bool retorno = false;

            if (c1.Codigo == c2.Codigo)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Cocina c1, Cocina c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Cocina)
            {
                if ((Cocina)obj == this)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public override string ToString()
        {
            return "Codigo: " + this.Codigo + " - Precio: " + this.Precio + " - Es industria? " + this.EsIndustria + "\n";    
        }
    }
}
