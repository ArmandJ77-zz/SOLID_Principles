using System;

namespace _5_Post_DependencyInversionPrinciple.Shapes
{
    public abstract class Shape
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
