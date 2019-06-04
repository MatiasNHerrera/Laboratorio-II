using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades_Clase17
{
    [Serializable] //indica que es una clase que se serializara.
    [XmlInclude(typeof(Profesor))] // nodos secundarios que se serializaran a partir de la clase base
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Persona))]

    public class Humano
    {
        private int dni;
       

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public override string ToString()
        {
            return "Dni: " + this.dni + "\n";
        }

    }
}
