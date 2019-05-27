using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int _añosExperiencia;

        public int MiExperiencia
        {
            get { return MiExperiencia; }
            set { this._añosExperiencia = value; }
        }


        public DirectorTecnico(string nombre, string apellido, int dni, int edad, int añosExperiencia) : base(nombre,apellido,edad,dni)
        {
            this._añosExperiencia = añosExperiencia;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append("- Años de experiencia: " + this._añosExperiencia);

            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;

            if(this._añosExperiencia >= 2 && base.Edad < 65)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
