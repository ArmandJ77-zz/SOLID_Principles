namespace _5_Post_DependencyInversionPrinciple.Shapes
{
    public class Square : Shape, ICalculation
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public double CalculateArea()
        {
            return Width * Length;
        }
    }
}
