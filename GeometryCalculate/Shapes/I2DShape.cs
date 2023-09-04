namespace GeometryCalculate.Shapes;

public interface I2DShape
{
    public decimal Length { get; set; }
    public decimal Width { get; set; }

    public decimal CalculateArea();
    public decimal CalculatePerimeter();
}

public interface I3DShape : I2DShape
{
    public decimal Height { get; set; }
    public decimal CalculateVolume();
}

public interface I2DInfiniteDiagonal
{
    public decimal Radius { get; set; }
    
    public decimal CalculateArea();
    public decimal CalculatePerimeter();
}
