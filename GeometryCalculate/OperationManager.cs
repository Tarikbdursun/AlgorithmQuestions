using GeometryCalculate.Shapes;

namespace GeometryCalculate;

public class OperationManager
{
    public void SetOperationType(I3DShape shape)
    {
        operationNumberPoint:

        Console.WriteLine(StringContainer.OperationTypeInput);

        int operationNumber = 0;
        string? operationInput = Console.ReadLine();
        if (int.TryParse(operationInput, out operationNumber))
        {
            switch (operationNumber)
            {
                case 1:
                    Console.WriteLine(shape.CalculatePerimeter());
                    break;
                case 2:
                    Console.WriteLine(shape.CalculateArea());
                    break;

                case 3:
                    Console.WriteLine(shape.CalculateVolume());
                    break;
                default: goto operationNumberPoint;
            }
        }
        else
        {
            Console.WriteLine(StringContainer.WrongInputFeedBack);
            goto operationNumberPoint;
        }
    }
    
    public void SetOperationType(I2DShape shape)
    {
        operationNumberPoint:

        Console.WriteLine(StringContainer.OperationTypeInput);

        int operationNumber = 0;
        string? operationInput = Console.ReadLine();
        if (int.TryParse(operationInput, out operationNumber))
        {
            switch (operationNumber)
            {
                case 1:
                    Console.WriteLine(shape.CalculatePerimeter());
                    break;
                case 2:
                    Console.WriteLine(shape.CalculateArea());
                    break;
                default: goto operationNumberPoint;
            }
        }
        else
        {
            Console.WriteLine(StringContainer.WrongInputFeedBack);
            goto operationNumberPoint;
        }
    }
    
    public void SetOperationType(I2DInfiniteDiagonal shape)
    {
        operationNumberPoint:

        Console.WriteLine(StringContainer.OperationTypeInput);

        int operationNumber = 0;
        string? operationInput = Console.ReadLine();
        if (int.TryParse(operationInput, out operationNumber))
        {
            switch (operationNumber)
            {
                case 1:
                    Console.WriteLine(shape.CalculatePerimeter());
                    break;
                case 2:
                    Console.WriteLine(shape.CalculateArea());
                    break;
                default: goto operationNumberPoint;
            }
        }
        else
        {
            Console.WriteLine(StringContainer.WrongInputFeedBack);
            goto operationNumberPoint;
        }
    }
    
    
}