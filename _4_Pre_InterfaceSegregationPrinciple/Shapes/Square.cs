using System;

namespace _4_Pre_InterfaceSegregationPrinciple.Shapes
{
    public class Square : ICalculation
    {
        public double Width { get; set; }

        public double CalculateArea()
        {
            return Width * Width;
        }

        public double CalculateAreaWithRadius()
        {
            throw new NotImplementedException();
        }
    }
}
