using _3_Pre_LiskovSubstitutionPrinciple.Shapes;
using System;
using System.Collections.Generic;

namespace _3_Pre_LiskovSubstitutionPrinciple
{
    /// <summary>
    /// The LSP states that "the object of a derived class should be able to replace an object of the base class 
    /// without bringing any errors in the system or modifying the behavior of the base class", the below code violates the LSP because
    /// the Square class can not act as a substitute for the rectangle class ass a result the CalculateArea will always invoke 
    /// the incorrect funciton to calculate the area
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Square();
            rect.Width = 10;
            rect.Height = 20;
            var result = AreaCalculator.CalculateArea(rect);

            Console.WriteLine($"{result} is incorrect as the code invoked the CalculateArea.CalculateArea(Recangle rect) method");
        }
    }
}