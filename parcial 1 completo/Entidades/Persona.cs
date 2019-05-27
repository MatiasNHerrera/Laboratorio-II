using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string _apellido;
        private int _dni;
        private int _edad;
        private string _nombre;

        public string Nombre
        {
            get { return this._nombre; }
        }

        public int Dni
        {
            get { return this._dni; }
        }

        public int Edad
        {
            get { return this._edad; }
        }

        public string Apellido
        {
            get { return this._apellido; }
        }

        public Persona(string nombre,string apellido, int edad, int dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._dni = dni;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre: " + this._nombre);
            sb.Append("- Apellido: " + this._apellido);
            sb.Append("- Dni: " + this._dni);
            sb.Append("- Edad: " + this._edad);

            return sb.ToString();
        }

        public abstract bool ValidarAptitud();




    }
}
