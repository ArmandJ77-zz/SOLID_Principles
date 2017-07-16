using _4_Post_InterfaceSegregationPrinciple.Shapes;
using System;

namespace _4_Post_InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square() { Width = 10 };
            var circle = new Circle() { Radius = 5 };

            //Would work
            var squareArea = square.CalculateArea();

            //No longer an option 
            //var exception = square.CalculateAreaWithRadius();
            var circleArea = circle.CalcAreaWithRadius();
        }
    }
}