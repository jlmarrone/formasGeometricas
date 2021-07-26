using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Formas;
using CodingChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class ImpresoraTest
    {
        [TestCase]
        public void TestEspañol()
        {
            Reporte i = new Reporte("es-ES");

            List<IFormaGeometrica> formas = new List<IFormaGeometrica>
            {
                new Rectangulo(4)
            };

            string reporte = i.Imprimir(formas);

            Assert.AreEqual(reporte, "<h1>Reporte de Formas</h1>1 Rectangulo | Area 16 | Perimetro 16 <br/>TOTAL:<br/>1 formas Perimetro: 16 Area: 16");
        }

        [TestCase]

        public void TestIngles()
        {
            Reporte i = new Reporte("en-US");

            List<IFormaGeometrica> formas = new List<IFormaGeometrica>
            {
                new Rectangulo(4)
            };

            string reporte = i.Imprimir(formas);

            Assert.AreEqual(reporte, "<h1>Shapes Report</h1>1 Rectangle | Area 16 | Perimeter 16 <br/>TOTAL:<br/>1 shapes Perimeter: 16 Area: 16");
        }


        [TestCase]
        public void TestEspañolVariasFormasRectangulos()
        {
            Reporte i = new Reporte("es-ES");

            List<IFormaGeometrica> formas = new List<IFormaGeometrica>
            {
                new Rectangulo(4),
                new Rectangulo(4, 8),
                new Rectangulo(4),
                new Rectangulo(4, 3)
            };

            string reporte = i.Imprimir(formas);

            Assert.AreEqual(reporte, "<h1>Reporte de Formas</h1>4 Rectangulos | Area 76 | Perimetro 70 <br/>TOTAL:<br/>4 formas Perimetro: 70 Area: 76");
        }

        [TestCase]
        public void TestEspañolNingunaForma()
        {
            Reporte i = new Reporte("es-ES");

            List<IFormaGeometrica> formas = new List<IFormaGeometrica>();
            string reporte = i.Imprimir(formas);

            Assert.AreEqual(reporte, "<h1>Lista Vacia de Formas</h1>");
        }


        [TestCase]
        public void TestInglesNingunaForma()
        {
            Reporte i = new Reporte("en-US");

            List<IFormaGeometrica> formas = new List<IFormaGeometrica>();
            string reporte = i.Imprimir(formas);

            Assert.AreEqual(reporte, "<h1>Shapes Empty List</h1>");
        }


        [TestCase]
        public void TestInglesVariasFormas()
        {
            Reporte i = new Reporte("en-US");

            List<IFormaGeometrica> formas = new List<IFormaGeometrica>
            {
                new Rectangulo(4),
                new Classes.Formas.Circulo(5.25),
                new Trapecio(4, 5, 5.40, 8),
                new Triangulo(4, 3, 8)
            };

            string reporte = i.Imprimir(formas);

            Assert.AreEqual(reporte, "<h1>Shapes Report</h1>1 Rectangle | Area 16 | Perimeter 16 <br/>1 Circle | Area 86.59 | Perimeter 32.99 <br/>1 Triangle | Area  | Perimeter 15 <br/>1 Trapeze | Area  | Perimeter 22.4 <br/>TOTAL:<br/>4 shapes Perimeter: 86.39 Area: 102.59");
        }
    }
}
