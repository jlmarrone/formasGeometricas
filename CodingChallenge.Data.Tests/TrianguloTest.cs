using CodingChallenge.Data.Classes.Formas;
using NUnit.Framework;
using System;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class TrianguloTest
    {
        [TestCase]
        public void Area()
        {
            Triangulo c = new Triangulo(5);

            Assert.AreEqual(10.83, Math.Round(c.CalcularArea(), 2));
        }

        [TestCase]
        public void Area_2Valores()
        {
            Triangulo c = new Triangulo(5, 5);

            Assert.AreEqual(10.83, Math.Round(c.CalcularArea(), 2));
        }

        [TestCase]
        public void Area_3Valores()
        {
            Triangulo c = new Triangulo(5, 7, 4);

            Assert.AreEqual(9.80, Math.Round(c.CalcularArea(), 2));
        }

        [TestCase]
        public void AreaValorCero()
        {
            Triangulo c = new Triangulo(0);

            Assert.AreEqual(0, c.CalcularArea());
        }


        [TestCase]
        public void Perimetro()
        {
            Triangulo c = new Triangulo(10);

            Assert.AreEqual(30, Math.Round(c.CalcularPerimetro(), 2));
        }

        [TestCase]
        public void Perimetro_2Valores()
        {
            Triangulo c = new Triangulo(6, 5);

            Assert.AreEqual(17, Math.Round(c.CalcularPerimetro(), 2));
        }

        [TestCase]
        public void Perimetro_3Valores()
        {
            Triangulo c = new Triangulo(5, 5, 4);

            Assert.AreEqual(14, Math.Round(c.CalcularPerimetro(), 2));
        }

        [TestCase]
        public void PerimetroValorCero()
        {
            Triangulo c = new Triangulo(0);

            Assert.AreEqual(0, c.CalcularPerimetro());
        }
    }
}
