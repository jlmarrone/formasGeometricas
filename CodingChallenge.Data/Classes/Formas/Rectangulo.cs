using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Rectangulo : IFormaGeometrica
    {
        public double Lado { get; set; }
        public double Lado2 { get; set; }

        public Rectangulo()
        {
        }
        public Rectangulo(double lado)
        {
            Lado = Lado2 = lado;
        }

        public Rectangulo(double lado, double lado2)
        {
            Lado = lado;
            Lado2 = lado2;
        }

        public double CalcularArea() => Lado * Lado2;

        public double CalcularPerimetro() => (Lado * 2) + (Lado2 * 2);
    }
}
