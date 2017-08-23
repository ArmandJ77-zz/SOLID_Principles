using System;

namespace _1_Post_SingleResponsibilityPrinciple.Shapes
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea() => Width * Height;

        public void Log(string message) => Console.WriteLine(message);
    }
}
