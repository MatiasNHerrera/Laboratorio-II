using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Estacionamientos.starter;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Estacionamiento est = new Estacionamiento(5);

      Assert.IsNotNull(est.Autos);

    }

    [TestMethod]
    public void espacioEstacionamientoIncorrecto()
    {
      Estacionamiento est = new Estacionamiento(101);
      Estacionamiento est2 = new Estacionamiento(0);

      if(est.EspacioDisponible != 101)
      {
        Assert.Fail("Fallo, el espacio dispobile es {0}", est.EspacioDisponible);
      }

      Assert.AreNotEqual(est2.EspacioDisponible, 1);

      if(est2.EspacioDisponible != 0)
      {
        Assert.Fail("Paso prueba de espacio disponible");
      }


    }

    [TestMethod]
    public void agregarAutos()
    {
      Estacionamiento e1 = new Estacionamiento(2);
      Auto a1 = new Auto("AAA-452", ConsoleColor.Black);
      Auto a2 = new Auto("AAD-321", ConsoleColor.Cyan);
      Auto a3 = new Auto("AAF-231", ConsoleColor.DarkGray);

      try
      {
        e1 += a1;
        e1 += a2;
        e1 += a3;
        Assert.Fail("Error, no se debe agregar el auto {0}", a3.Patente);
      }
      catch(Exception e)
      {
        Assert.IsInstanceOfType(e, typeof(EstacionamientoLlenoException));
      }

    }

    [TestMethod]
    public void agregarAutoEspacioDisponible()
    {
      Estacionamiento est = new Estacionamiento(2);

      Auto a1 = new Auto("AAA-444", ConsoleColor.Black);
      Auto a2 = new Auto("DSA-232", ConsoleColor.Cyan);

      est += a1;

      Assert.AreEqual(est.EspacioDisponible, 1);

      est += a2;

      Assert.AreEqual(est.EspacioDisponible, 0);
    }
  }
}
