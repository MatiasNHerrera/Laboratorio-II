using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
   public class Program
    {
        static void Main(string[] args)
        {
            Sello.Color = ConsoleColor.Red; //cambio color

            Sello.ImprimirEnColor(); //cambio color en consola y muestro con formato ya cambiado

            Console.WriteLine(Sello.Imprimir());// muestro el mensaje con formato ya armado

            Console.ReadKey();
            
        }
    }
}
