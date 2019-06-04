using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades_Clase17
{
    public class Alumno : Persona
    {
        private int _legajo;

        public int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Legajo: " + this._legajo; 
        }
        



    }
}
