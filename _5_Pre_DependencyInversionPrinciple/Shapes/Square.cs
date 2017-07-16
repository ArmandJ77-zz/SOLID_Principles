namespace _5_Pre_DependencyInversionPrinciple.Shapes
{
    public class Square : Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public override double CalculateArea()
        {
            return Width * Length;
        }
    }
}
