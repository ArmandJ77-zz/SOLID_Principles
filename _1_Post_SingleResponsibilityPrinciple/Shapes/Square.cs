using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Post_SingleResponsibilityPrinciple.Shapes
{
    public class Square
    {
        public double Width { get; set; }

        /// <summary>
        /// we can ommit the this keyword infornt of the Width properties as its infered by the property names on the object
        /// </summary>
        /// <returns></returns>
        public double CaluclateArea() {
            return Width * Width;
        }

        public void Log(string message) {
            Console.WriteLine(message);
        }
    }
}
