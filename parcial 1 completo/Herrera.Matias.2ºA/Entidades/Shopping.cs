using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Shopping
    {
        private int _capacidad;
        private List<Comercio> comercios;

        private Shopping()
        {
            this.comercios = new List<Comercio>();
        }

        private Shopping(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public static string Mostrar(Shopping c)
        {
            string retorno = "";

            retorno += "Capacidad del Shopping: " + c._capacidad + "\n";
            retorno += "Total por Importadores: " + c.PrecioImportador + "\n";
            retorno += "Total por Exportadores: " + c.PrecioExportador + "\n";
            retorno += "Total por ambos: " + c.PrecioTotal + "\n\n";
            retorno += "*****************************\n";
            retorno += "Listado de Comercios\n";
            retorno += "*****************************\n\n";

            foreach(Comercio co in c.comercios)
            {
                if(co is Importador)
                {
                   retorno += ((Importador)co).Mostrar();
                }
                else
                {
                   retorno += ((Exportador)co).Mostrar();
                }
            }

            return retorno;
        }

        public static implicit operator Shopping(int capacidad)
        {
            Shopping s = new Shopping(capacidad);

            return s;
        }

        public static bool operator == (Shopping s, Comercio c)
        {
            bool retorno = false;

            foreach(Comercio co in s.comercios)
            {
                if(co == c)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Shopping s, Comercio c)
        {
            return !(s == c);
        }

        public static Shopping operator +(Shopping s, Comercio c)
        {
            bool validacion = false;

            foreach(Comercio co in s.comercios)
            {
                if (co is Importador && c is Importador)
                {
                    if (((Importador)co) == ((Importador)c))
                    {
                        validacion = true;
                        break;
                    }
                }
                else if(co is Exportador && c is Exportador)
                {
                    if (((Exportador)co) == ((Exportador)c))
                    {
                        validacion = true;
                        break;
                    }
                }

 
               
            }

            if(validacion == false && s.comercios.Count < s._capacidad)
            {
                s.comercios.Add(c);
            }
            else if(s.comercios.Count >= s._capacidad)
            {
                Console.WriteLine("No hay mas capacidad en el Shopping !!\n");
            }
            else
            {
                Console.WriteLine("El comercio ya esta en el shopping\n");
            }

            return s;
        }


        private double ObtenerPrecio(EComercio tipoComercio)
        {
            double retorno = 0;
        
            foreach(Comercio c in this.comercios)
            {
                if(c is Importador && tipoComercio == EComercio.Importador)
                {
                    retorno += ((Importador)c);
                }
                else if(c is Exportador && tipoComercio == EComercio.Exportador)
                {
                    retorno += ((Exportador)c);
                }
                else if(tipoComercio == EComercio.Ambos)
                {
                    if(c is Importador)
                    {
                        retorno += ((Importador)c);
                    }
                    else
                    {
                        retorno += ((Exportador)c);
                    }
                }
            }

            return retorno;
        }

        public double PrecioImportador
        {
            get { return this.ObtenerPrecio(EComercio.Importador); }
        }

        public double PrecioExportador
        {
            get { return this.ObtenerPrecio(EComercio.Exportador); }
        }


        public double PrecioTotal
        {
            get { return this.ObtenerPrecio(EComercio.Ambos); }
        }


    }
}
