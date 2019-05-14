using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herrera.Matias._2ºA
{
    public class Exportador : Comercio
    {
        public ETipoProducto tipo;

        public Exportador(string nombreComercio, float precioAlquiler, string nombre, string apellido, ETipoProducto tipo) : base(precioAlquiler, nombreComercio, nombre, apellido)
        {
            this.tipo = tipo;
        }

        public string Mostrar()
        {
            return (string)base._comerciante + " -Tipo: " +this.tipo;
        }

        public static bool operator ==(Exportador e1, Exportador e2)
        {
            bool retorno = false;

            if(e1.tipo == e2.tipo && e1._nombre == e2._nombre)
            {
                retorno = true;
            }

            return retorno;
                
        }

        public static bool operator !=(Exportador e1, Exportador e2)
        {
            return !(e1 == e2);
        }

        public static implicit operator double(Exportador m)
        {
            return m._precioAlquiler;
        }


           


    }
}
