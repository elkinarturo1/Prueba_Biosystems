using Bussines.Clases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared;
using System;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {

        ConfigurationModel objConfiguration = new ConfigurationModel();

        [TestMethod]
        public void probarConfiguracion()
        {
            Assert.ThrowsException<ArgumentNullException>(() => objConfiguration.ConfigInitial());
        }

        [TestMethod]
        public void probarPartidoJugar()
        {
            clsPartido programa1 = new clsPartido();
            string resultExpected = "jugador1";
            var result = programa1.jugar();
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void probarSetJugar()
        {
            clsSet programa1 = new clsSet(objConfiguration);
            string resultExpected = "jugador1";
            var result = programa1.jugar();
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void probarGameJugar()
        {
            clsGame programa1 = new clsGame(objConfiguration);
            string resultExpected = "jugador1";
            var result = programa1.jugar();
            Assert.AreEqual(resultExpected, result);
        }

    }
}
