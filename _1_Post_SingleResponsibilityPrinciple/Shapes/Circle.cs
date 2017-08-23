using System;

namespace _1_Post_SingleResponsibilityPrinciple.Shapes
{
    public class Circle
    {
        public double Radius { get; set; }
        public double Diameter { get; set; }

        public double CalculateAreaWithRadius() => (Radius * Radius) * Math.PI;

        public void Log() => Console.WriteLine($"Given a circle radius of {Radius} when calculating the area by using Area = (Radius * Radius) * PI then the result is {CalculateAreaWithRadius()}");
    }
}
