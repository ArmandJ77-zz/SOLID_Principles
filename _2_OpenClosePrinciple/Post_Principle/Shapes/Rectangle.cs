namespace _2_OpenClosePrinciple.Post_Principle.Shapes.Post_Principle
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea() 
        {
            return Width * Height;
        }
    }
}
