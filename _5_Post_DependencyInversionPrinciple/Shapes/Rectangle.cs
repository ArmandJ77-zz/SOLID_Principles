namespace _5_Post_DependencyInversionPrinciple.Shapes
{
    public class Rectangle : Shape, ICalculation
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
