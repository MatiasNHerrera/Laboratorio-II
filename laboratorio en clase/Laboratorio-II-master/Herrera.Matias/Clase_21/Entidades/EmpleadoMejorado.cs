using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpleadoMejorado
    {
        private string _nombre;
        private int _legajo;
        private float _sueldo;
        public event DelSueldo _delSueldo;


        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public float Sueldo
        {
            get { return this._sueldo; }
            set
            {
                if(value > 12000)
                {
                    EmpleadoSueldoArgs em = new EmpleadoSueldoArgs();
                    em.Sueldo = value;
                    this._delSueldo(this, em);
                }
                else
                {
                    this._sueldo = value;
                }
            }
        }


        public override string ToString()
        {
            return this._legajo + " | " + this._nombre + " | " + this._sueldo;
        }
    }
}
