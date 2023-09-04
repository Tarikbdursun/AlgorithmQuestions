// See https://aka.ms/new-console-template for more information

using GeometryCalculate;
using GeometryCalculate.Shapes;

OperationManager operationManager = new OperationManager();
ShapeContainer shapeContainer = new ShapeContainer();

Triangle triangle = new Triangle();
shapeContainer.AddShape(triangle);
Square square = new Square();
shapeContainer.AddShape(square);
Rectangle rectangle = new Rectangle();
shapeContainer.AddShape(rectangle);
Cube cube = new Cube();
shapeContainer.AddShape(cube);
Circle circle = new Circle();
shapeContainer.AddShape(circle);


int shapeType = 0;
shapeTypeInputPoint:

Console.WriteLine(StringContainer.ShapeTypeInput);

string? input = Console.ReadLine();
if (int.TryParse(input, out shapeType))
{
    var shape = shapeContainer.ShapeList.FirstOrDefault(x => x.ShapeType == (ShapeType)shapeType);

    switch (shape)
    {
        case I3DShape shape3D:
            Shape3DRequires(shape3D);
            break;

        case I2DShape shape2D:
            Shape2DRequires(shape2D);
            break;

        case I2DInfiniteDiagonal shape2dInfinite:
            ShapeInfiniteDiagonalRequired(shape2dInfinite);
            break;

        default: goto shapeTypeInputPoint;
    }

    void Shape2DRequires(I2DShape shape)
    {
        Console.WriteLine(StringContainer.LengthInput);
        decimal length = 0;
        string lengthInput = Console.ReadLine();
        length = decimal.Parse(lengthInput);
        shape.Length = length;
        if ((ShapeType)shapeType != ShapeType.Square)
        {
            Console.WriteLine(StringContainer.WidthInput);
            decimal width = 0;
            string widthInput = Console.ReadLine();
            width = decimal.Parse(widthInput);
            shape.Width = width;
        }
        else
        {
            shape.Width = length;
        }

        operationManager.SetOperationType(shape);
    }

    void Shape3DRequires(I3DShape shape)
    {
        Console.WriteLine(StringContainer.LengthInput);
        decimal length = 0;
        string lengthInput = Console.ReadLine();
        length = decimal.Parse(lengthInput);

        Console.WriteLine(StringContainer.WidthInput);
        decimal width = 0;
        string widthInput = Console.ReadLine();
        width = decimal.Parse(widthInput);

        Console.WriteLine(StringContainer.HeightInput);
        decimal height = 0;
        string heightInput = Console.ReadLine();
        height = decimal.Parse(heightInput);
        shape.Length = length;
        shape.Width = width;
        shape.Height = height;
        
        operationManager.SetOperationType(shape);
    }

    void ShapeInfiniteDiagonalRequired(I2DInfiniteDiagonal shape)
    {
        Console.WriteLine(StringContainer.RadiusInput);
        decimal radius = 0;
        string radiusInput = Console.ReadLine();
        radius = decimal.Parse(radiusInput);
        shape.Radius = radius;
        
        operationManager.SetOperationType(shape);
    }
}
else
{
    Console.WriteLine(StringContainer.WrongInputFeedBack);
    goto shapeTypeInputPoint;
}
Console.WriteLine();