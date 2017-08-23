using System;

namespace _1_Post_SingleResponsibilityPrinciple.Shapes
{
    public class Square
    {
        public double Width { get; set; }

        public double CaluclateArea() => Width * Width;

        public void Log(string message) => Console.WriteLine(message);
    }
}
