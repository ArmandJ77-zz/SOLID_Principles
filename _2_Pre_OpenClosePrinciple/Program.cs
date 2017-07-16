using _2_Pre_OpenClosePrinciple.Shapes;
using System;

namespace _2_Pre_OpenClosePrinciple
{
    /// <summary>
    /// The Open/closed Principle states that a software module is open for extension and closed for modification
    /// the below class creates a bunch of shapes and calculates their area then it calculates the sum of all the areas, however
    /// the class violates the OCP due becase when we add a trianlge shape here we have to:
    /// 1) Modify (make change) to the Main Method 
    /// 2) if we had written a unit test for Main then that test would also require modification and re-testing
    /// 3) we can not extend the totalArea formula when we add a tiangle to it
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square() { Width = 20 };
            var rectangle = new Rectangle { Width = 40, Height = 20 };
            var circle = new Circle() { Diameter = 10 };

            var squareArea = square.CaluclateArea();
            var rectangleArea = rectangle.CalculateArea();
            var circleArea = circle.CalculateAreaWithDiameter();

            var totalArea = squareArea + rectangleArea + circleArea;

            Console.WriteLine($"Total Area: {totalArea}");
        }
    }
}