using System;

namespace _5_Pre_DependencyInversionPrinciple.Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return (Radius * Radius) * Math.PI;
        }
    }
}
