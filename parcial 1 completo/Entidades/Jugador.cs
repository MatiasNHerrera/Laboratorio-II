using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float _altura;
        private float _peso;
        ETipoPosicion _posicion;

        public float Altura
        {
            get { return this._altura; }
        }

        public float Peso
        {
            get { return this._peso; }
        }

        public ETipoPosicion Posicion
        {
            get { return this._posicion; }
        }

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, ETipoPosicion posicion) : base(nombre,apellido,edad,dni)
        {
            this._altura = altura;
            this._peso = peso;
            this._posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append("- Peso: " + this._peso);
            sb.Append("- Altura: " + this._altura);
            sb.Append("- Posicion: " + this._posicion + "\n\n");

            return sb.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            float imc = 0;

            imc = this._peso / float.Parse((Math.Pow(2, this._altura)).ToString());

            if(imc > 18.5 && imc <= 25)
            {
                retorno = true;
            }

            return retorno;
           
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;

            if(base.Edad < 40 && ValidarEstadoFisico())
            {
                retorno = true;
            }

            return retorno;
        }






    }
}
