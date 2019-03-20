using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Sello
    {
        public static string Mensaje = "Hola putitos";
        
        public static ConsoleColor Color; //creo variable de color

        public static string Imprimir() // Retorna el atributo "mensaje".
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar() // Permite borrar el mensaje pasandole espacios en blanco.
        {
            Sello.Mensaje = " ";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.Color; // cambia el color de la consola

            Console.WriteLine(Sello.Imprimir()); //imprimo el mensaje

            Console.ReadKey();

            Color = ConsoleColor.White; // vuelvo a cambiar el color

            Console.ForegroundColor = Sello.Color; //cambio el color en consola

            Console.WriteLine(Sello.Imprimir()); // vuelvo a imprimir el mensaje

            Console.ReadKey();

            
        }

        private static string ArmarFormatoMensaje()
        {
            int len;
            string techo = "";
            string mensajeFormato = "";

            len = Sello.Mensaje.Length + 2; // obtengo el tamaño del mensaje


            for (int i = 0; i < len; i++)
            {
                techo += "*"; // coloco tantos asteriscos como letras tenga el mensaje
            }

            mensajeFormato += techo; //agrego los asteriscos medidos al mensaje

            mensajeFormato += "\n"; //salto de linea para llegar al mensaje

            mensajeFormato += "*" + Sello.Mensaje  + "*\n"; //agrego astericos al costado del mensaje y hago salto de linea

            mensajeFormato += techo; // agrego piso al mensaje

            return mensajeFormato; // retorno aquel mensaje


        }
    }
}
