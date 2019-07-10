using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;

        static Libro()
        {
            _generadorDePaginas = new Random();
        }

        public Libro(float precio, string titulo, string nombre, string apellido)
        {
            this._precio = precio;
            this._titulo = titulo;
            this._autor = new Autor(nombre, apellido);
        }

        public Libro(string titulo, Autor autor, float precio)
        {
            this._titulo = titulo;
            this._precio = precio;
            this._autor = autor;
        }

        public int CantidadDePaginas
        {
            get
            {
                if(this._cantidadDePaginas == 0)
                {
                    this._cantidadDePaginas = _generadorDePaginas.Next(10, 580);
                }

                return this._cantidadDePaginas;
            }
        }

        private static string Mostrar(Libro l)
        {
            string retorno = " ";

            retorno += "TITULO: " + l._titulo + "\n";
            retorno += "CANTIDAD DE PAGINAS: " + l.CantidadDePaginas + "\n";
            retorno += "AUTOR: " + l._autor + "\n";
            retorno += "PRECIO: " + l._precio + "\n";

            return retorno;
        }

        public static bool operator == (Libro l1, Libro l2)
        {
            bool retorno = false;

            if(l1._autor == l2._autor && l1._titulo == l2._titulo)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1 == l2);
        }

        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }

    }
}
