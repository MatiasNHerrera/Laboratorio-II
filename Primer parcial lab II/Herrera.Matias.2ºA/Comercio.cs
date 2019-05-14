using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herrera.Matias._2ºA
{
    public class Comercio
    {
        protected int _cantidadEmpleados;
        protected Comerciante _comerciante;
        protected static Random _generadorDeEmpleados;
        protected string _nombre;
        protected float _precioAlquiler;


        public int CantidadDeEmpleados
        {
            get
            {

                if(this._cantidadEmpleados == 0)
                {
                    this._cantidadEmpleados = _generadorDeEmpleados.Next(0, 100);
                }

                return this._cantidadEmpleados;

            }
        }

        static Comercio()
        {
            _generadorDeEmpleados = new Random();
        }

        public Comercio(float precioAlquiler, string nombreComercio, string nombre, string apellido)
        {
            this._comerciante = new Comerciante(apellido, nombre);
            this._precioAlquiler = precioAlquiler;
            this._nombre = nombreComercio;
  
        }

        public Comercio(string nombre, Comerciante comerciante, float precioAlquiler) 
        {
            this._precioAlquiler = precioAlquiler;
            this._nombre = nombre;
            this._comerciante = comerciante;
        }

        private static string Mostrar(Comercio c)
        {
            return "Nombre Comercio: " + c._nombre + "Precio alquiler: " + c._precioAlquiler + "Cantidad Empleados: " + c._cantidadEmpleados + "Comerciante Datos: " + c._comerciante;
        }

        public static bool operator ==(Comercio c1, Comercio c2)
        {
            bool retorno = false;

            if(c1._nombre == c2._nombre && c1._comerciante == c2._comerciante)
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
            return Comercio.Mostrar(c);
        }

    }
}
