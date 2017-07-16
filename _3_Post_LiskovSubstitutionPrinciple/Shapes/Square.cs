namespace _3_Post_LiskovSubstitutionPrinciple.Shapes
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
