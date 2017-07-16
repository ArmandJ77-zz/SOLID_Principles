namespace _2_Post_OpenClosePrinciple.Shapes
{
    public class Square : Shape
    {
        public double Width { get; set; }

        public override double CalculateTotalArea()
        {
            return Width * Width;
        }
    }
}
