namespace GeometryCalculate.Shapes;

public class Triangle : BaseShape,I2DShape
{
    public decimal Length { get; set; }
    public decimal Width { get; set; }

    public Triangle()
    {
        ShapeType = ShapeType.Triangle;
    }
    
    public decimal CalculateArea()
    {
        return Length * Width / 2;
    }

    public decimal CalculatePerimeter()
    {
        return (decimal)Math.Sqrt(Math.Pow((double)Length, 2) + Math.Pow((double)Width / 2, 2))*2+Width;
    }
}