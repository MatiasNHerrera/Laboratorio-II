using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesVehiculo;

namespace pruebaVehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto nuevoAuto = new Auto(5,"dsadas", EMarca.Honda, 4);
            Moto nuevaMoto = new Moto(2.5, "dasda", EMarca.Zanella, 2);
            Camion nuevoCamion = new Camion("dsadasd", EMarca.Scania, 8, 2.5);
            
            Lavadero elLavadero = new Lavadero(120000, 400000, 30000);

            Console.WriteLine(elLavadero.MiLavadero);

            Console.ReadKey();

        }
    }
}
