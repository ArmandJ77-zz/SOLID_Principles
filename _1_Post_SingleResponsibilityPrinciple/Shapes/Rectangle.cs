using System;

namespace _1_Post_SingleResponsibilityPrinciple.Shapes
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea() => Width * Height;

        public void Log() => Console.WriteLine($"Given a rectangle width of {Width} and {Height} when calculating the area by using Area = w * h then the result is {CalculateArea()}");
    }
}
