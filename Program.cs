using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_05.Entidades;


namespace Clase_06test
{
    class Program
    {
        static void Main(string[] args)
        {

            Paleta objPaleta = 8;
            Tempera objTempera = new Tempera(ConsoleColor.Black, "Super color", 20);

            Console.WriteLine((string)objPaleta);

            Console.ReadKey();

        }
    }
}
