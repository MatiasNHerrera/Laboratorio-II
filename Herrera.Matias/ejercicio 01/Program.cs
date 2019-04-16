using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librerias;

namespace ejercicio_01
{
    class ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title= "ejercicio_01";

            int Numeros;
            int i;
            int Maximo=0;
            int Minimo = 0;
            float Prom = 0;

            Console.WriteLine(test.salvar());

            for (i = 0; i < 5; i++)
            {

                Console.WriteLine("Ingrese numeros: ");

                Numeros = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    Maximo = Numeros;
                    Minimo = Numeros;
                }
               
                if(Numeros >= Maximo)
                {
                    Maximo = Numeros;
                }
                else if(Numeros <= Minimo)
                {
                    Minimo = Numeros;
                }

                Prom = Prom + Numeros;
            }

            Console.WriteLine("maximo:{0} ",Maximo);
            Console.WriteLine("minimo:{0} ",Minimo);
            Console.WriteLine("Promedio:{0} ",Prom /5);
            Console.ReadKey();

        }
    }
}
