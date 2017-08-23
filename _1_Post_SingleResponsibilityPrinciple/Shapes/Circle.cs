using System;

namespace _1_Post_SingleResponsibilityPrinciple.Shapes
{
    public class Circle
    {
        public double Radius { get; set; }
        public double Diameter { get; set; }

        public double CalculateAreaWithRadius() => (Radius * Radius) * Math.PI;

        public double CalculateAreaWithDiameter() => (Math.PI / 4) * (Diameter * Diameter);

        public void Log(string message) => Console.WriteLine(message);
    }
}
