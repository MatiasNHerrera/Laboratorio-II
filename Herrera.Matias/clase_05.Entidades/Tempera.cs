using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_05.Entidades
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private sbyte _cantidad;

        public Tempera(ConsoleColor color, string marca, sbyte cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cantidad;
        }

        private string Mostrar()
        {
            return (this._color + "-" + this._cantidad + "-" + this._marca).ToString();
        }

        public static string Mostrar(Tempera auxMostrar)
        {
            string retorno = "vacio";

            if (!object.Equals(auxMostrar, null))
            {
                retorno = auxMostrar.Mostrar();
            }
            
            return retorno;
           
        }

        public static bool operator  == (Tempera marca, Tempera color)
        {
            bool retorno = false;

            if(Equals(marca, null) && Equals(color,null))
            {
                retorno = true;
            }
            else if(Equals(marca, null) || Equals(color, null))
            {
                retorno = false;
            }
            else if(marca._marca == color._marca && marca._color == color._color)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (Tempera marca, Tempera color)
        {
            return !(marca == color);
        }

        public static Tempera operator + (Tempera cantidad1, sbyte cantidad2)
        {
            cantidad1._cantidad += cantidad2;

            return cantidad1;
        }

        public static Tempera operator + (Tempera auxTempera, Tempera auxTempera2)
        {
            if(auxTempera == auxTempera2)
            {
                auxTempera += auxTempera2._cantidad;
            }

            return auxTempera;
        }

        public static implicit operator sbyte(Tempera auxCantidad)
        {
            return auxCantidad._cantidad;
        }

        private string marca;

        public string miMarca
        {
            get { return marca = this._marca; }
        }

        private ConsoleColor color;

        public ConsoleColor MiColor
        {
            get { return this._color; }
        }



    }
}
