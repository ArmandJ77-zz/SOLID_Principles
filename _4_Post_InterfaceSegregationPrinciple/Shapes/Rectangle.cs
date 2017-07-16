using System;

namespace _4_Post_InterfaceSegregationPrinciple.Shapes
{
    public class Rectangle : ICalcRadius
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
