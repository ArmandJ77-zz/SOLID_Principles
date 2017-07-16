using System;

namespace _2_Post_OpenClosePrinciple.Shapes
{
    public abstract class Shape
    {
        public abstract double CalculateTotalArea();

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
