using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_05.Entidades;

namespace Clase_05.test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tinta obj2 = new Tinta(ConsoleColor.Blue);
            //Tinta obj3 = new Tinta(ETipoTinta.China, ConsoleColor.Red);

            //Console.WriteLine(Tinta.Mostrar(obj1));
            //Console.WriteLine(Tinta.Mostrar(obj2));
            //Console.WriteLine(Tinta.Mostrar(obj3));

            /* Tinta t1 = new Tinta();
               Tinta t2 = new Tinta(ConsoleColor.Blue);
               Tinta t3 = new Tinta(ETipoTinta.China, ConsoleColor.Red);
               Tinta t4 = new Tinta();
               Tinta t5 = t1;


               Console.WriteLine(Tinta.Mostrar(t1));
               Console.WriteLine(Tinta.Mostrar(t2));
               Console.WriteLine(Tinta.Mostrar(t3));

               if(t1 == t4)//Equals se encarga de comparar si los parametros pasados son iguales (de tipo object)
               {
                   Console.WriteLine("Son iguales");
               }
               else
               {
                   Console.WriteLine("No son iguales");
               }

               */

            Tinta objT = new Tinta();
            Pluma objP = new Pluma("BIC", 20, objT);
          
            
            objP = objP + objT;
            string s = (string)objP;

            Console.WriteLine(s);

            Console.ReadKey();

            
        }
    }
}
