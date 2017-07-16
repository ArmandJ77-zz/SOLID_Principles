using System;

namespace _1_Pre_SingleResponsibilityPrinciple
{
    /// <summary>
    /// As at its most basic level the SRP states that a module should only have one reason to change
    /// in the example below calculating area of the objects, logging to the console 
    /// and we have multiple classes in the same .cs file, thus this class has multiple concerns which violates the SRP.
    /// </summary>
    class Program
    {
        static void Main (string[] args)
        {
            var square = new Square() { Width = 20 };
            Console.WriteLine("Creating a square that has a width of: 20");

            var squareArea = square.Width * 4;
            Console.WriteLine($"The area of that Square is: {squareArea}");

            var rectangle = new Rectangle { Width = 40, Height = 20 };
            Console.WriteLine("Creating a Rectangle that has a width of 40 and a height of 20");

            var rectangleArea = rectangle.Width * rectangle.Height;
            Console.WriteLine($"The area of that Square is: {rectangleArea}");

            var circle = new Circle() { Radius = 10 };
            Console.WriteLine("Creating a Circle with a radius of 10");
            var circleArea = (circle.Radius * circle.Radius) * Math.PI;
            Console.WriteLine($"The radius of a Circle is: {circleArea}");

            Console.WriteLine("Calculate the Area of a circle by using the Diameter");
            var circleWithNoRadius = new Circle() { Diameter = 10 };
            var circleWithNoRadiusArea = (Math.PI / 4) * (circleWithNoRadius.Diameter * circleWithNoRadius.Diameter);
            Console.WriteLine($"Result: {circleWithNoRadiusArea}");

        }
    }

    public class Circle
    {
        public double Radius { get; set; }
        public double Diameter { get; set; }
    }

    public class Square
    {
        public double Width { get; set; }
    }

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }
}