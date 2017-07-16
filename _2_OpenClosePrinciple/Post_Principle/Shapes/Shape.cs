using System;

namespace _2_OpenClosePrinciple.Post_Principle.Shapes
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
