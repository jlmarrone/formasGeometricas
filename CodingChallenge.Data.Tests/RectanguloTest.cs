using CodingChallenge.Data.Classes.Formas;
using NUnit.Framework;
using System;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class RectanguloTest
    {
        [TestCase]
        public void Area()
        {
            Rectangulo c = new Rectangulo(10);

            Assert.AreEqual(100, Math.Round(c.CalcularArea(), 2));
        }

        [TestCase]
        public void Area_2Valores()
        {
            Rectangulo c = new Rectangulo(6, 8);

            Assert.AreEqual(48, Math.Round(c.CalcularArea(), 2));
        }

        [TestCase]
        public void AreaValorCero()
        {
            Rectangulo c = new Rectangulo(0);

            Assert.AreEqual(0, c.CalcularArea());
        }


        [TestCase]
        public void Perimetro()
        {
            Rectangulo c = new Rectangulo(8);

            Assert.AreEqual(32, Math.Round(c.CalcularPerimetro(), 2));
        }

        [TestCase]
        public void Perimetro_2Valores()
        {
            Rectangulo c = new Rectangulo(5, 9);

            Assert.AreEqual(28, Math.Round(c.CalcularPerimetro(), 2));
        }

        [TestCase]
        public void PerimetroValorCero()
        {
            Rectangulo c = new Rectangulo(0);

            Assert.AreEqual(0, c.CalcularPerimetro());
        }
    }
}
