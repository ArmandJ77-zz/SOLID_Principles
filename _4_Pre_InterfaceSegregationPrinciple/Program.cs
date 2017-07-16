using _4_Pre_InterfaceSegregationPrinciple.Shapes;
using System;

namespace _4_Pre_InterfaceSegregationPrinciple
{
    /// <summary>
    /// The ISP states that no client should be forced to depend on methods it does not use. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square() { Width = 10 };
            var circle = new Circle();

            //Would work
            var squareArea = square.CalculateArea();

            //However this opens us to exception
            var exception = square.CalculateAreaWithRadius();

        }
    }
}