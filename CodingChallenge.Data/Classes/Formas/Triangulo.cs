using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Triangulo : IFormaGeometrica
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Base { get; set; }

        public Triangulo()
        {
        }
        public Triangulo(double lado)
        {
            Lado1 = lado;
            Lado2 = lado;
            Base = lado;
        }

        public Triangulo(double lado, double base_)
        {
            Lado1 = lado;
            Lado2 = lado;
            Base = base_;
        }

        public Triangulo(double lado1, double lado2, double base_)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Base = base_;
        }

        public double CalcularArea()
        {
            double perimetro = CalcularPerimetro() / 2;
            try
            {
                double resultado = Math.Sqrt(perimetro *
                                            (perimetro - Lado1) *
                                            (perimetro - Lado2) *
                                            (perimetro - Base));

                return double.IsNaN(resultado) ? 0 : resultado;
            }
            catch
            {
                return 0;
            }

        }

        public double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Base;
        }
    }
}
