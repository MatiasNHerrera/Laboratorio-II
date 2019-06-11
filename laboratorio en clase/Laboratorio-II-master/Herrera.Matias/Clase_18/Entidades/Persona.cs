using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public int _id;
        public string _nombre;
        public string _apellido;
        public int edad;

        public Persona(int id, string nombre, string apellido, int edad)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this.edad = edad;
        }

        public override string ToString()
        {
            return this._id + " | " + this._nombre + " | " + this._apellido + " | " + this.edad;
        }

    }
}
