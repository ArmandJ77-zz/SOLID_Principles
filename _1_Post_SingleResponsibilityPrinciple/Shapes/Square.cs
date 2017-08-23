using System;

namespace _1_Post_SingleResponsibilityPrinciple.Shapes
{
    public class Square
    {
        public double Width { get; set; }

        public double CalculateArea() => Width * Width;

        public void Log() => Console.WriteLine($"Given a square width of {Width} when calculating the area by using Area = a * a then the result is {CalculateArea()}");
    }
}
