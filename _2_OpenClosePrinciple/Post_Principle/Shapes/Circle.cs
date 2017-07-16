using System;

namespace _2_OpenClosePrinciple.Post_Principle.Shapes.Post_Principle
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
