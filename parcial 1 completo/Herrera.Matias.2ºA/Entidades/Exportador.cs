using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Exportador : Comercio
    {
        public ETipoProducto tipoProducto;

        public Exportador(string nombreComercio, float precioAlquiler, string nombre, string apellido, ETipoProducto tipo) : base(precioAlquiler, nombreComercio, nombre, apellido)
        {
            this.tipoProducto = tipo;
        }

        public string Mostrar()
        {
            return (string)this + "Tipo De Producto: " + this.tipoProducto + "\n\n";
        }

        public static bool operator == (Exportador e1, Exportador e2)
        {
            bool retorno = false;

            if(e1.tipoProducto == e2.tipoProducto && ((Comercio)e1) == ((Comercio)e2))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Exportador e1, Exportador e2)
        {
            return !(e1 == e2);
        }

        public static implicit operator float(Exportador e)
        {
            return e._precioAlquiler;
        }


    }
}
