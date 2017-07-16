using _5_Post_DependencyInversionPrinciple.Shapes;
using System;
using System.Collections.Generic;

namespace _5_Post_DependencyInversionPrinciple
{
    class Program
    {
        /// <summary>
        /// See ShapeCaluclations Class for detail on change
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ICollection<ICalculation> shapes = new List<ICalculation>()
            {
                new Rectangle() { Height = 20.5, Width=40.7},
                new Square() { Width = 35.4}
            };

            // Granted this line can be removed should we impliment IShapeCalculations 
            // and use .Net Core's IOC to inject it into the Program instance thus removeing the dependency on the "new keyword"
            // IOC is out of scope for this article
            var shapeCalculations = new ShapeCalculations(shapes);
            var areaList = shapeCalculations.CalculateArea();

            areaList.ForEach(x => Console.WriteLine($"Area: {x}"));
        }
    }
}