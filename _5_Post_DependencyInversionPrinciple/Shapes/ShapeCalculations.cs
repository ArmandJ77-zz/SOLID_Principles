using _5_Post_DependencyInversionPrinciple.Shapes;
using System.Collections.Generic;
using System.Linq;

namespace _5_Post_DependencyInversionPrinciple
{
    /// <summary>
    /// By using constructor injection and the ICalculations class we have 
    /// removed the dependency on the lower module "Shape" by using abstractions
    /// </summary>
    public class ShapeCalculations
    {
        private ICollection<ICalculation> _caluclations;
        
        public ShapeCalculations(ICollection<ICalculation> caluclations) {
            _caluclations = caluclations;
        }

        public List<double> CalculateArea() {
            var area = new List<double>();

            _caluclations.ToList().ForEach(x => area.Add(x.CalculateArea()));

            return area;
        }
    }
}
