namespace GeometryCalculate.Shapes;

public class ShapeContainer
{
    public List<BaseShape> ShapeList { get; private set; }= new();

    public void AddShape(BaseShape shape)
    {
        ShapeList.Add(shape);
    }
}