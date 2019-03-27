using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_04Libreria
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;


        public string Mostrar()
        {
            string retorno = "";

            retorno = ("entero: " + this.entero + "  - cadena: " + this.cadena + " - fecha: " + this.fecha).ToString();

            return retorno;
        }

        public static string Mostrar(Cosa obj)
        {
            string retorno = "";

            retorno = obj.Mostrar();

            return retorno;
             
        }

        public void establecerValor(int entero)
        {
            this.entero = entero;
            
        }

        public void establecerValor(string cadena)
        {
           this.cadena = cadena;     
        }

        public void establecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public Cosa()
        {
            this.entero = 10;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }

        public Cosa(int entero) : this()
        {
            this.entero = entero;
            //this.cadena = "Sin valor";
            //this.fecha = DateTime.Now;
        }

        public Cosa(int entero, DateTime fecha) : this(entero)
        {
           // this.entero = entero;
           // this.cadena = "Sin valor";
            this.fecha = fecha;
            

        }

        public Cosa(int entero, DateTime fecha, string cadena) : this(entero, fecha)
        {
            //this.entero = entero;
            this.cadena = cadena;
           // this.fecha = fecha;
        }

    }   
}
