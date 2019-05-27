using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercio
    {
        protected int _cantidadEmpleados;
        protected Comerciante _comerciante;
        protected static Random _generadorDeEmpleados;
        protected string _nombreComercio;
        protected float _precioAlquiler;


        static Comercio()
        {
            _generadorDeEmpleados = new Random();
        }

        public Comercio(float precioAlquiler, string nombreComercio, string nombre, string apellido)
        {
            this._precioAlquiler = precioAlquiler;
            this._nombreComercio = nombreComercio;
            this._comerciante = new Comerciante(nombre, apellido);
        }

        public Comercio(string nombre, Comerciante comerciante, float precioAlquiler)
        {
            this._nombreComercio = nombre;
            this._comerciante = comerciante;
            this._precioAlquiler = precioAlquiler;
        }
            


        public int CantidadDeEmpleados
        {
            get
            {
                if(this._cantidadEmpleados == 0)
                {
                    return this._cantidadEmpleados = _generadorDeEmpleados.Next(1, 100);
                }
                else
                {
                    return this._cantidadEmpleados;
                }
            }
        }

        public static string Mostrar(Comercio c)
        {
            return (string)c;
        }

        public static bool operator == (Comercio c1, Comercio c2)
        {
            bool retorno = false;

            if(c1._nombreComercio == c2._nombreComercio && c1._comerciante == c2._comerciante)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Comercio c1, Comercio c2)
        {
            return !(c1 == c2);
        }

        public static explicit operator string(Comercio c)
        {
            return "Nombre Comercio: " + c._nombreComercio + "\nPrecio Alquiler: " + c._precioAlquiler + "\nCantidad Empleados: " + c.CantidadDeEmpleados + "\nComerciante: " + c._comerciante + "\n";
        }


    }
}
