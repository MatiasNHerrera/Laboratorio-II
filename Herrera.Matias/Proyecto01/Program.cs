using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso un nombre y lo muestro en consola:

            string Nombre;

            Console.Write("Ingrese su nombre: ");

            Nombre = Console.ReadLine();

            Console.WriteLine(Nombre);

            Console.ReadKey();

        }
    }
}
