namespace GeometryCalculate.Shapes;

public class Rectangle : BaseShape,I2DShape
{
    public decimal Length { get; set; }
    public decimal Width { get; set; }

    public Rectangle()
    {
        ShapeType = ShapeType.Rectangle;
    }
    
    public decimal CalculateArea()
    {
        return Length * Width;
    }

    public decimal CalculatePerimeter()
    {
        return Length * 2 + Width * 2;
    }
}