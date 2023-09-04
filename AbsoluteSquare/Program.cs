// See https://aka.ms/new-console-template for more information

numbersInputPoint:
List<int> numbers = new();
List<int> smallNumbers = new();
List<int> biggerNumbers = new();
int bigResult=0;
int smallResult=0;


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
        int result = 0;
        
            currentValue = int.Parse(seperatedNumbers[i]);
            result = 67 - currentValue;
            if (result>0)
            {
                //Küçük olduğu durum
                smallNumbers.Add(result);
            }
            else
            {
                //Büyük olduğu durum
                result=(int)Math.Pow(Math.Abs(result),2);
                biggerNumbers.Add(result);
            }
    }

    foreach (int smallNumber in smallNumbers)
    {
        smallResult += smallNumber;
    }
    
    foreach (int bigNumber in biggerNumbers)
    {
        bigResult += bigNumber;
    }
    Console.WriteLine($"{smallResult} {bigResult}");
}
catch
{
    goto numbersInputPoint;
}