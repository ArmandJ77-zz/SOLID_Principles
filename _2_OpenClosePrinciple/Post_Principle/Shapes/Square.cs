namespace _2_OpenClosePrinciple.Post_Principle.Shapes.Post_Principle
{
    public class Square : Shape
    {
        public double Width { get; set; }

        public override double CalculateArea()
        {
            return Width * Width;
        }
    }
}
