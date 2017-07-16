using _3_Post_LiskovSubstitutionPrinciple.Shapes;
using System.Collections.Generic;

namespace _3_Post_LiskovSubstitutionPrinciple
{
    public class ShapeCalculations
    {
        public List<double> CalculateArea(List<Shape> shapeList) {
            var area = new List<double>();

            shapeList.ForEach(x => area.Add(x.CalculateArea()));

            return area;
        }
    }
}
