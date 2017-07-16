using System;

namespace _4_Post_InterfaceSegregationPrinciple.Shapes
{
    public class Circle : Shape, ICalcOther
    {
        public double Diameter { get; set; }
        public double Radius { get; set; }

        public double CalcAreaWithRadius()
        {
            return (Radius * Radius) * Math.PI;
        }

        public double CalcAreaWithDiameter()
        {
            return (Math.PI / 4) * (Diameter * Diameter);
        }
    }
}
