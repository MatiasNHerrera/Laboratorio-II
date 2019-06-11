using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Persona> p = new List<Persona>();
            Persona persona = new Persona(5, "Sebastian", "Alvarez", 4);

            

            if(datos.AgregarPersona(persona))
            {
                Console.WriteLine("\nSe pudo agregar a la lista\n\n");
            }
            else
            {
                Console.WriteLine("No se pudo");
            }

            p = datos.TraerTodos();

            foreach (Persona pe in p)
            {
                Console.WriteLine(pe.ToString());
            }


            Console.ReadKey();
        }
    }
}
