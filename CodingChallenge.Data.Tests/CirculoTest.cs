using CodingChallenge.Data.Classes.Formas;
using NUnit.Framework;
using System;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class CirculoTest
    {
        [TestCase]
        public void Area()
        {
            Circulo c = new Circulo(6);

            Assert.AreEqual(113.10m, Math.Round(c.CalcularArea(), 2));
        }

        [TestCase]
        public void AreaValorCero()
        {
            Circulo c = new Circulo(0);

            Assert.AreEqual(0, c.CalcularArea());
        }


        [TestCase]
        public void Perimetro()
        {
            Circulo c = new Circulo(6);

            Assert.AreEqual(37.70m, Math.Round(c.CalcularPerimetro(), 2));
        }

        [TestCase]
        public void PerimetroValorCero()
        {
            Circulo c = new Circulo(0);

            Assert.AreEqual(0, c.CalcularPerimetro());
        }

    }
}
