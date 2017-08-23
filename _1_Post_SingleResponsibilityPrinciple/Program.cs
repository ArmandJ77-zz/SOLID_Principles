using _1_Post_SingleResponsibilityPrinciple.Shapes;

namespace _1_Post_SingleResponsibilityPrinciple
{
    class Program
    {

        static void Main(string[] args)
        {
            var square = new Square() { Width = 20 };
            var rectangle = new Rectangle { Width = 40, Height = 20 };
            var circle = new Circle() { Radius = 10 };
            var circleWithNoRadius = new Circle() { Diameter = 10 };

            square.Log();
            rectangle.Log();            
            circle.Log();          
        }
    }
}
