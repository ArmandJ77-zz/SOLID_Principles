using System;

namespace _4_Post_InterfaceSegregationPrinciple.Shapes
{
    public abstract class Shape
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
