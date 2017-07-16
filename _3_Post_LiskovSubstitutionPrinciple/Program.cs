using _3_Post_LiskovSubstitutionPrinciple.Shapes;
using System;
using System.Collections.Generic;

namespace _3_Post_LiskovSubstitutionPrinciple
{
    /// <summary>
    /// We have technically resolved the LSP since we added the shape base class on the 
    /// rectangle, square and circle classes an abstracted the area calculations 
    /// to a seperate class
    /// </summary>
    class Program
    {
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