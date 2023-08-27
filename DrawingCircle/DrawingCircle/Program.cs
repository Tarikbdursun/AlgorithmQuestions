// See https://aka.ms/new-console-template for more information

using System.Numerics;

startPoint:
Console.WriteLine("Please Give A Radius Value To Draw Circle");
string? input = Console.ReadLine();
double radius;

if (double.TryParse(input, out radius))
{
    for (int i = 0; i <= 2*radius; i++)
    {
        for (int j = 0; j <= 2*radius; j++)
        {
            double pointDiff = Math.Sqrt(Math.Pow(i - radius, 2) + Math.Pow(j - radius, 2));
            Console.Write(pointDiff > radius-.5 && pointDiff<radius+.5 ? "*" : " ");
        }

        Console.WriteLine();
    }
}
else
{
    Console.WriteLine($"'{input}' can't be a radius value \nPlease Try Again");
}
goto startPoint;