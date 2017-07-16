using _5_Pre_DependencyInversionPrinciple.Shapes;
using System;
using System.Collections.Generic;

namespace _5_Pre_DependencyInversionPrinciple
{
    class Program
    {
        /// <summary>
        /// The DIP states that:
        /// "High level modules should not depend upon low level modules. 
        /// Both should depend upon abstractions.
        /// Abstractions should not depend upon details.
        /// Details should depend upon abstractions."
        /// the ShapeCalculations class violates this principle as it is 
        /// tightly couples to the shapes base class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var shapes = new List<Shape>()
            {
                new Rectangle() { Height = 20.5, Width=40.7},
                new Square() { Width = 35.4}
            };

            var shapeCalculations = new ShapeCalculations();
            var areaList = shapeCalculations.CalculateArea(shapes);

            areaList.ForEach(x => Console.WriteLine($"Area: {x}"));
        }
    }
}