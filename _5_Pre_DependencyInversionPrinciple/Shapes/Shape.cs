using System;

namespace _5_Pre_DependencyInversionPrinciple.Shapes
{
    public abstract class Shape
    {
        public abstract double CalculateArea();

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
