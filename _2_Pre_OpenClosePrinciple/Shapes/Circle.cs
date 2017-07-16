using System;

namespace _2_Pre_OpenClosePrinciple.Shapes
{
    public class Circle
    {
        public double Radius { get; set; }
        public double Diameter { get; set; }

        public double CalculateAreaWithRadius() {
            return (Radius * Radius) * Math.PI;
        }

        public double CalculateAreaWithDiameter()
        {
            return (Math.PI / 4) * (Diameter * Diameter);
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
