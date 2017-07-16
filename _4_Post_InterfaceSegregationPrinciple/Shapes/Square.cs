using System;

namespace _4_Post_InterfaceSegregationPrinciple.Shapes
{
    public class Square : ICalcRadius
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public double CalculateArea()
        {
            return Width * Length;
        }
    }
}
