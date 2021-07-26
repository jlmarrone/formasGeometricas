using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Circulo : IFormaGeometrica
    {
        public double Radio { get; set; }

        public Circulo()
        {
        }
        public Circulo(double radio)
        {
            Radio = radio;
        }
        public double CalcularArea()
        {
            return Math.PI * (Radio * Radio);
        }

        public double CalcularPerimetro()
        {
            return Math.PI * Radio * 2;
        }
    }
}
