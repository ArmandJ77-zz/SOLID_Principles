using System;

namespace _4_Pre_InterfaceSegregationPrinciple.Shapes
{
    public class Rectangle : ICalculation
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculateAreaWithRadius()
        {
            throw new NotImplementedException();
        }
    }
}
