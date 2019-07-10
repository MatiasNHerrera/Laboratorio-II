using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }

        private Biblioteca(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public double PrecioDeManuales
        {
            get { return this.ObtenerPrecio(ELibro.Manual); }
        }

        public double PrecioDeNovelas
        {
            get { return this.ObtenerPrecio(ELibro.Novela);}
        }

        public double PrecioAmbos
        {
            get { return this.ObtenerPrecio(ELibro.Ambos); }
        }

        public static bool operator == (Biblioteca b, Libro l)
        {
            bool retorno = false;

            foreach(Libro li in b._libros)
            {
                if (li is Manual && l is Manual)
                {
                    if (((Manual)li) == ((Manual)l))
                    {
                        retorno = true;
                        break;
                    }
                }
                else if(li is Novela && l is Novela)
                {
                    if(((Novela)li) == ((Novela)l))
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Biblioteca b, Libro l)
        {
            return !(b == l);
        }

        public static Biblioteca operator + (Biblioteca b, Libro l)
        {
            bool validacion = false;

            if(!(b == l) && b._libros.Count < b._capacidad)
            {
                validacion = true;
            }
            
            if(validacion)
            {
                b._libros.Add(l);
            }
            else if(b._libros.Count >= b._capacidad)
            {
                Console.WriteLine("Ya no hay mas lugar en la biblioteca!!!");
            }
            else
            {
                Console.WriteLine("El libro ya esta en la biblioteca!!!");
            }

            return b;
        }

        public static string Mostrar(Biblioteca b)
        {
            string retorno = "";

            retorno += "Capacidad de la biblioteca: " + b._capacidad + "\n";
            retorno += "Total por Manuales: " + b.PrecioDeManuales.ToString() + "\n";
            retorno += "Total por Novelas: " + b.PrecioDeNovelas.ToString() + "\n";
            retorno += "Total: " + b.PrecioAmbos.ToString() + "\n";
            retorno += "********************\n";
            retorno += "Listado de libros\n";
            retorno += "********************\n\n";
               
            
            foreach(Libro l in b._libros)
            {
                if(l is Manual)
                {
                    retorno += ((Manual)l).Mostrar();
                }
                else
                {
                    retorno += ((Novela)l).Mostrar();
                }
            }

            return retorno;
        }

        public static implicit operator Biblioteca (int capacidad)
        {
            Biblioteca be = new Biblioteca(capacidad);

            return be;
        }

        private double ObtenerPrecio(ELibro Tipolibro)
        {
            double retorno = 0;

            foreach(Libro l in this._libros)
            {
                if(Tipolibro == ELibro.Manual && l is Manual)
                {
                    retorno += ((Manual)l);
                }
                else if (Tipolibro == ELibro.Novela && l is Novela)
                {
                    retorno += ((Novela)l);
                }
                else if(Tipolibro == ELibro.Ambos)
                {
                    if (l is Manual)
                    {
                        retorno += ((Manual)l);
                    }
                    else
                    {
                        retorno += ((Novela)l);
                    }
                }
            }

            return retorno;
        }
    }
}
