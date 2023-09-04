namespace GeometryCalculate.Shapes;

public class Circle : BaseShape, I2DInfiniteDiagonal
{
    public decimal Radius { get; set; }

    public Circle()
    {
        ShapeType = ShapeType.Circle;
    }

    public decimal CalculateArea()
    {
        return (decimal)(Math.Pow(((double)Radius), 2) * Math.PI);
    }

    public decimal CalculatePerimeter()
    {
        return   (decimal)(Math.PI* 2 * (float)Radius);
    }
}