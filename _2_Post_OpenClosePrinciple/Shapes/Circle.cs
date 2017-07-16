using System;

namespace _2_Post_OpenClosePrinciple.Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateTotalArea()
        {
            return (Radius * Radius) * Math.PI;
        }
    }
}
