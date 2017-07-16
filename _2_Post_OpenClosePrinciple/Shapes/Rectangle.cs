namespace _2_Post_OpenClosePrinciple.Shapes
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateTotalArea()
        {
            return Width * Height; 
        }
    }
}
