// See https://aka.ms/new-console-template for more information

numbersInputPoint:
List<int> numbers = new();
List<int> addedNumbers = new();

Console.WriteLine("Please Give A Number Array With Spaces");
string? numbersInput;
numbersInput = Console.ReadLine();

try
{
    string[] seperatedNumbers = numbersInput.Split(" ");

    foreach (string number in seperatedNumbers)
    {
        try
        {
            int.Parse(number);
        }
        catch (Exception e)
        {
            Console.WriteLine("Please Try Again");
            goto numbersInputPoint;
        }
    }

    for (int i = 0; i < seperatedNumbers.Length; i++)
    {
        int currentValue = 0;
        int nextValue = 0;
        int result = 0;


        if (i == seperatedNumbers.Length - 1)
        {
            result = int.Parse(seperatedNumbers[i]);
            addedNumbers.Add(result);
            break;
        }

        if (i % 2 == 0)
        {
            currentValue = int.Parse(seperatedNumbers[i]);
            nextValue = int.Parse(seperatedNumbers[i + 1]);
            result = currentValue + nextValue;
            if (currentValue == nextValue)
            {
                result = (int)Math.Pow((currentValue * 2), 2);
            }

            addedNumbers.Add(result);
        }
    }

    foreach (int addedNumber in addedNumbers)
    {
        Console.WriteLine(addedNumber);
    }
}
catch
{
    goto numbersInputPoint;
}