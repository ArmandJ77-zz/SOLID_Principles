using _2_OpenClosePrinciple.Post_Principle.Shapes;
using System.Collections.Generic;

namespace _2_OpenClosePrinciple.Post_Principle
{
    public class ShapeCalculations
    {
        public double CaluclateTotalArea(List<Shape> shapeList) {
            var total = 0.0;

            shapeList.ForEach(x => total += x.CalculateArea());

            return total;
        }
    }
}
