namespace GeometryCalculate.Shapes;

public class Cube : BaseShape,I3DShape
{
    public decimal Length { get; set; }
    public decimal Width { get; set; }

    public Cube()
    {
        ShapeType = ShapeType.Cube;
    }

    public decimal CalculateArea()
    {
        decimal firstArea = Length * Width * 2;
        decimal secondArea = Length * Height * 2;
        decimal thirdArea = Height * Width * 2;
        return firstArea + secondArea + thirdArea;
    }

    public decimal CalculatePerimeter()
    {
        decimal totalLenght = Length * 4;
        decimal totalHeight = Height * 4;
        decimal totalWidth = Width * 4;
        return totalLenght + totalHeight + totalWidth;
    }

    public decimal Height { get; set; }

    public decimal CalculateVolume()
    {
        return Height * Length * Width;
    }
}