using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Trapecio : IFormaGeometrica
    {
        public double Lado { get; set; }
        public double Lado2 { get; set; }
        public double Base1 { get; set; }
        public double Base2 { get; set; }

        public Trapecio()
        {
        }
        public Trapecio(double lado, double lado2, double base1, double base2)
        {
            Lado = lado;
            Lado2 = lado2;
            Base1 = base1;
            Base2 = base2;
        }

        public double CalcularArea()
        {
            double totalBases = Base1 + Base2;
            double denominador = 4 * (Math.Abs(Base1 - Base2));
            try
            {
                double raiz = Math.Sqrt((-Base1 + Base2 + Lado + Lado2) *
                                        (-Base1 - Base2 + Lado + Lado2) *
                                        (-Base1 - Base2 + Lado - Lado2) *
                                        (Base1 - Base2 - Lado + Lado2));

                if (double.IsNaN(raiz))
                    return 0;

                return totalBases / denominador * raiz;
            }
            catch
            {
                return 0;
            }
        }

        public double CalcularPerimetro()
        {
            return Lado + Lado2 + Base1 + Base2;
        }

    }
}
