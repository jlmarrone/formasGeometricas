using CodingChallenge.Data.Classes.Formas;
using CodingChallenge.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CodingChallenge.Data.Classes
{
    public class Reporte
    {
        public Reporte(string selectedLanguage)
        {
            Thread.CurrentThread.CurrentUICulture = 
                new System.Globalization.CultureInfo(selectedLanguage);
        }

        public string Imprimir(List<IFormaGeometrica> formas)
        {
            StringBuilder reporte = new StringBuilder();

            if (!formas.Any())
                reporte.Append(Language.ListaVacia);

            else
            {
                reporte.Append(Language.Reporte);

                int numeroRectangulos = 0;
                int numeroCirculos = 0;
                int numeroTriangulos = 0;
                int numeroTrapecios = 0;

                double areaRectangulos = 0;
                double areaCirculos = 0;
                double areaTriangulos = 0;
                double areaTrapecios = 0;

                double perimetroRectangulos = 0;
                double perimetroCirculos = 0;
                double perimetroTriangulos = 0;
                double perimetroTrapecios = 0;

                foreach (IFormaGeometrica forma in formas)
                {
                    if (forma.GetType() == typeof(Rectangulo))
                    {
                        numeroRectangulos++;
                        areaRectangulos += forma.CalcularArea();
                        perimetroRectangulos += forma.CalcularPerimetro();
                    }

                    else if (forma.GetType() == typeof(Circulo))
                    {
                        numeroCirculos++;
                        areaCirculos += forma.CalcularArea();
                        perimetroCirculos += forma.CalcularPerimetro();
                    }

                    else if (forma.GetType() == typeof(Triangulo))
                    {
                        numeroTriangulos++;
                        areaTriangulos += forma.CalcularArea();
                        perimetroTriangulos += forma.CalcularPerimetro();
                    }

                    else if (forma.GetType() == typeof(Trapecio))
                    {
                        numeroTrapecios++;
                        areaTrapecios += forma.CalcularArea();
                        perimetroTrapecios += forma.CalcularPerimetro();
                    }
                }

                int totalFormas = CalcularCantidadFormas(numeroRectangulos , numeroCirculos , numeroTriangulos , numeroTrapecios);
                double totalPerimetro = CalcularTotalPerimetro(perimetroRectangulos, perimetroTriangulos, perimetroTrapecios, perimetroCirculos);
                double totalArea = CalcularTotalArea(areaRectangulos, areaCirculos, areaTriangulos, areaTrapecios);

                reporte.Append(Traducir(numeroRectangulos, areaRectangulos, perimetroRectangulos, new Rectangulo()));
                reporte.Append(Traducir(numeroCirculos, areaCirculos, perimetroCirculos, new Circulo()));
                reporte.Append(Traducir(numeroTriangulos, areaTriangulos, perimetroTriangulos, new Triangulo()));
                reporte.Append(Traducir(numeroTrapecios, areaTrapecios, perimetroTrapecios, new Trapecio()));
                reporte.Append(Language.Total);
                reporte.Append($"{totalFormas} {Language.Formas} ");
                reporte.Append($"{Language.Perimetro}: {totalPerimetro:#.##} ");
                reporte.Append($"{ Language.Area}: { totalArea:#.##}");
            }

            return reporte.ToString();
        }


        private string Traducir(int cantidad, double area, double perimetro, IFormaGeometrica tipo)
        {
            if (cantidad > 0)
            {
                Traductor traductor = Traductor.GetInstance;

                return $"{cantidad} {traductor.Traducir(tipo, cantidad)} | {Language.Area} {area:#.##} | {Language.Perimetro} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        private int CalcularCantidadFormas(int numeroRectangulos ,int numeroCirculos ,int numeroTriangulos , int numeroTrapecios)
        {
            return numeroRectangulos + numeroCirculos + numeroTriangulos + numeroTrapecios;
        }

        private double CalcularTotalPerimetro(double perimetroRectangulos, double perimetroTriangulos, double perimetroTrapecios, double perimetroCirculos)
        {
            return perimetroRectangulos + perimetroTriangulos + perimetroCirculos + perimetroTrapecios;
        }

        private double CalcularTotalArea(double areaRectangulos , double areaCirculos , double areaTriangulos , double areaTrapecios)
        {
            return areaRectangulos + areaCirculos + areaTriangulos + areaTrapecios;
        }
    }
}
