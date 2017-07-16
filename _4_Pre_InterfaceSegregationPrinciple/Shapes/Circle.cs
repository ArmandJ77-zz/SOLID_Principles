using System;

namespace _4_Pre_InterfaceSegregationPrinciple.Shapes
{
    public class Circle : ICalculation
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public double CalculateAreaWithRadius()
        {
            return (Radius * Radius) * Math.PI;
        }
    }
}
