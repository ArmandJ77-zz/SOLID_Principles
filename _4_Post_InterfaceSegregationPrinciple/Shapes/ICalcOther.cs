using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Post_InterfaceSegregationPrinciple.Shapes
{
    public interface ICalcOther
    {
        double CalcAreaWithRadius();
        double CalcAreaWithDiameter();
    }
}
