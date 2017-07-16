using System;

namespace _5_Post_DependencyInversionPrinciple.Shapes
{
    public class Circle : Shape, ICalculation
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return (Radius * Radius) * Math.PI;
        }
    }
}
