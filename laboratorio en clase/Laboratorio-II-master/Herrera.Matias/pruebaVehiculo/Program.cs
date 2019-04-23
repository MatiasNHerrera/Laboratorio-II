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
            Lavadero elLavadero = new Lavadero(200, 500, 120);
            Auto nuevoAuto2 = new Auto(5, "fffff", EMarca.Fiat, 4);
            Auto nuevoAuto = new Auto(5,"dsadas", EMarca.Honda, 4);
            Moto nuevaMoto = new Moto(2.5, "dasda", EMarca.Zanella, 2);
            Camion nuevoCamion = new Camion("dsadasd", EMarca.Scania, 8, 2.5);
            Camion nuevoCamion2 = new Camion("tewtewtw", EMarca.Scania, 8, 3.0);

            elLavadero += nuevoAuto;
            elLavadero += nuevaMoto;
            elLavadero += nuevoCamion;
            elLavadero += nuevoAuto2;
            elLavadero += nuevoCamion2;
            

            Console.WriteLine(elLavadero.MiLavadero);

            Console.WriteLine("el total facturado es: " + elLavadero.MostraTotalFacturado());
            Console.WriteLine("el total factura por auto es: " + elLavadero.MostrarTotalFacturado(EVehiculo.Auto));
            Console.WriteLine("el total factura por moto es: " + elLavadero.MostrarTotalFacturado(EVehiculo.Moto));
            Console.WriteLine("el total factura por camion es: " + elLavadero.MostrarTotalFacturado(EVehiculo.Camion));

            Console.ReadKey();

        }
    }
}
