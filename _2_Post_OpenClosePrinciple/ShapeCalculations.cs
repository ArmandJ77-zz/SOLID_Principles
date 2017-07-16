using _2_Post_OpenClosePrinciple.Shapes;
using System.Collections.Generic;

namespace _2_Post_OpenClosePrinciple
{
    public class ShapeCalculations
    {
        public double CalculateTotalArea(List<Shape> shapeList) {
            var total = 0.0;

            shapeList.ForEach(x => total += x.CalculateTotalArea());

            return total;
        }
    }
}
