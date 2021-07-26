using CodingChallenge.Data.Classes.Formas;
using NUnit.Framework;
using System;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class TrapecioTest
    {

        [TestCase]
        public void Area_BasesDistintas()
        {
            Trapecio c = new Trapecio(15, 12, 10, 8);

            Assert.AreEqual(130.71, Math.Round(c.CalcularArea(), 2));
        }

        [TestCase]
        public void Perimetro_BasesDistintas()
        {
            Trapecio c = new Trapecio(5, 6, 12, 12);

            Assert.AreEqual(35, Math.Round(c.CalcularPerimetro(), 2));
        }
    }
}
