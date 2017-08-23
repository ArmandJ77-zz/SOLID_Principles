using _1_Post_SingleResponsibilityPrinciple.Shapes;

namespace _1_Post_SingleResponsibilityPrinciple
{
    class Program
    {
        /// <summary>
        /// 1) this class has no concern over the shape classes as they have been moved to their own files
        /// 2) calculations are abstracted to their shape classes
        /// 3) loggin occurs in the shape class not the main class
        /// 4) the Program class is easier to read as the amount of code has been reduced
        /// 5) the Program class's primary concern is to properties of the shapes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var square = new Square() { Width = 20 };
            var rectangle = new Rectangle { Width = 40, Height = 20 };
            var circle = new Circle() { Radius = 10 };
            var circleWithNoRadius = new Circle() { Diameter = 10 };

            square.Log($"Given a square width of {square.Width} when calculating the area by using Area = a * a then the result is {square.CaluclateArea()}");
            rectangle.Log($"Given a rectangle width of {rectangle.Width} and {rectangle.Height} when calculating the area by using Area = w * h then the result is {rectangle.CalculateArea()}");            
            circle.Log($"Given a circle radius of {circle.Radius} when calculating the area by using Area = (Radius * Radius) * PI then the result is {circle.CalculateAreaWithRadius()}");          
            circle.Log($"Given a circle diameter of {circleWithNoRadius.Diameter} when calculating the area by using Area = (Math.PI / 4) * (Diameter * Diameter) then the result is {circleWithNoRadius.CalculateAreaWithDiameter()}");
        }
    }
}
