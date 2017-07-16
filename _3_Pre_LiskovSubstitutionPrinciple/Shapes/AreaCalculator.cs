using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Pre_LiskovSubstitutionPrinciple.Shapes
{
    public class AreaCalculator
    {
        public static double CalculateArea(Rectangle rect)
        {
            return rect.Width * rect.Height;
        }

        public static double CalculateArea(Square square)
        {
            return square.Width * square.Width; 
        }
    }
}
