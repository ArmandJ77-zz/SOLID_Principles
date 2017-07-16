using _2_Post_OpenClosePrinciple.Shapes;
using System;
using System.Collections.Generic;

namespace _2_Post_OpenClosePrinciple
{
    /// <summary>
    /// first we crate an abstract base class called Shape and add it as a base class to rectangle, square and circle
    /// then the impliment the Calculate area function and remove the other functions. We also moved the log function the the Shape base class
    /// Note the log function is just for demo purposes and should not be taken into account
    /// Then we create a class which will handle all shape calculation by accepting a list of shapes, 
    /// by iterating over each shape we invoke its calculateArea function and add it to a total variable and return
    /// Then in the logic flow class this case Program, we instantiate a new list of shape and ShapeCalculations
    /// and finally invoking the CalculateTotalArea and passing the shapes as paramter befor we log the total are ot the console
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>()
            {
                new Rectangle() { Height = 20.5, Width=40.7},
                new Square() { Width = 35.4},
                new Circle() { Radius = 1.5 }
            };

            var shapeCalculations = new ShapeCalculations();
            var totalArea = shapeCalculations.CalculateTotalArea(shapes);

            Console.WriteLine($"Total area: {totalArea}");
        }
    }
}