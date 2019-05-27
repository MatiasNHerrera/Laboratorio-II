using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        const int _cantidadMaximaJugadores = 6;
        private DirectorTecnico _directorTecnico;
        private List<Jugador> _jugadores;
        private string _nombre;


        public DirectorTecnico ElDirectorTecnico
        {
            set
            {   if(value.ValidarAptitud())
                {
                    this._directorTecnico = value;
                }
            }
        }

        public string NombreEquipo
        {
            get { return this._nombre; }
        }

        private Equipo()
        {
            this._jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this._nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre del equipo: " + e._nombre + "\n");
            if(e._directorTecnico != null)
            {
                sb.Append("Director tecnico: " + e._directorTecnico.Nombre + "\n");
            }
            else
            {
                sb.Append("Director tecnico: " + "Dt no asignado\n\n");
            }

            sb.Append("\n-----JUGADORES-----\n");

            foreach(Jugador j in e._jugadores)
            {
                sb.Append(j.Mostrar());
            }

            return sb.ToString();
        }

        public static bool operator == (Equipo e, Jugador jdr)
        {
            bool retorno = false;

            foreach(Jugador j in e._jugadores)
            {
                if(j.Dni == jdr.Dni)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Equipo e, Jugador jdr)
        {
            return !(e == jdr);
        }

        public static Equipo operator +(Equipo e, Jugador jdr)
        {
            int cantidad = e._jugadores.Count();

            if(!(e == jdr) && cantidad < 6 && jdr.ValidarAptitud())
            {
                e._jugadores.Add(jdr);
            }

            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool retorno = false;
            int iArquero = 0;
            int iCentral = 0;
            int iDefensor = 0;
            int iDelantero = 0;
            int cantidadJugadores = e._jugadores.Count();

            foreach(Jugador j in e._jugadores)
            {
                if(j.Posicion == ETipoPosicion.Arquero)
                {
                    iArquero++;
                }
                else if(j.Posicion == ETipoPosicion.Central)
                {
                    iCentral++;
                }
                else if(j.Posicion == ETipoPosicion.Defensor)
                {
                    iDefensor++;
                }
                else if(j.Posicion == ETipoPosicion.Delantero)
                {
                    iDelantero++;
                }
            }

            if(iArquero <= 1 && iCentral >= 1 && iDelantero >= 1 && iDefensor >= 1 && e._directorTecnico != null && cantidadJugadores == 6)
            {
                retorno = true;
            }

            return retorno;
        }





    }
}
