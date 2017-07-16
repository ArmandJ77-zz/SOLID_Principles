using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Pre_InterfaceSegregationPrinciple.Shapes
{
    public interface ICalculation
    {
        double CalculateArea();
        double CalculateAreaWithRadius();
    }
}
