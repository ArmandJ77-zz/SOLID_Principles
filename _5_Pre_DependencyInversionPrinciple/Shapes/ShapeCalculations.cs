using _5_Pre_DependencyInversionPrinciple.Shapes;
using System.Collections.Generic;

namespace _5_Pre_DependencyInversionPrinciple
{
    public class ShapeCalculations
    {
        public List<double> CalculateArea(List<Shape> shapeList) {
            var area = new List<double>();

            shapeList.ForEach(x => area.Add(x.()));

            return area;
        }
    }
}
