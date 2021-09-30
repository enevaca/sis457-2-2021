using ClassLibraryNetStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DemoUnitTest
{
    [TestClass]
    public class UnitTestCalc
    {
        [TestMethod]
        public void TestSuma()
        {
            // Variables (Arrange)
            var numero1 = 5;
            var numero2 = 6;

            // Ejecución (Act)
            var resultado = Calculadora.sumar(numero1, numero2);

            // Comprobación de resultados (Assert)
            var valorEsperado = 11;
            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        public void TestMultiplicacion()
        {
            // Variables (Arrange)
            var numero1 = 5;
            var numero2 = 6;

            // Ejecución (Act)
            var resultado = Calculadora.multiplicar(numero1, numero2);

            // Comprobación de resultados (Assert)
            var valorEsperado = 30;
            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        public void TestDivision()
        {
            // Variables (Arrange)
            var numero1 = 12;
            var numero2 = 6;

            // Ejecución (Act)
            var resultado = Calculadora.dividir(numero1, numero2);

            // Comprobación de resultados (Assert)
            var valorEsperado = 2;
            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionExcepcion()
        {
            // Variables (Arrange)
            var numero1 = 12;
            var numero2 = 0;

            // Ejecución (Act)
            var resultado = Calculadora.dividir(numero1, numero2);

            // Comprobación de resultados (Assert)
            //var valorEsperado = 2;
            //Assert.AreEqual(valorEsperado, resultado);
        }
    }
}
