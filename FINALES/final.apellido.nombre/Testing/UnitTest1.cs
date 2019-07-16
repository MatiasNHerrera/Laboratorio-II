using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestImparPar()
        {
            Int32 entero = new Int32();
            entero = 4;

            Assert.IsTrue(entero.esPar());

            entero = 5;

            Assert.IsTrue(entero.esImpar());
            
        }

        [TestMethod]
        public void ElDelMedio()
        {
            int elDelMedio = 0;

            Assert.IsTrue(Comparadora.GetElDelMedio(1, 4, 2, out elDelMedio));
        }
    }
}
