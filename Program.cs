using System;
using clase_04Libreria;

namespace clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa obj1 = new Cosa();
            Cosa obj2 = new Cosa(7);
            Cosa obj3 = new Cosa(7, DateTime.Today);
            Cosa obj4 = new Cosa(7, DateTime.Today, "Hola mundo");

             /*obj.establecerValor(10);
             obj.establecerValor("hola mundo");
             obj.establecerValor(DateTime.Now);

             Console.WriteLine(obj.Mostrar()); */

            Console.WriteLine(obj1.Mostrar());
            Console.WriteLine(obj2.Mostrar());
            Console.WriteLine(obj3.Mostrar());
            Console.WriteLine(obj4.Mostrar());




            Console.ReadKey();
            
        }
    }
}
