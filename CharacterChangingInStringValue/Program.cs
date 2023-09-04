// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;

firstPoint:
Console.WriteLine("Please Give an Input");
string? input = Console.ReadLine();

try
{
    string[] seperatedInput = input.Split(" ");
    foreach (string s in seperatedInput)
    {
        ChangeFirstAndLastCharacter(s);
    }
}
catch
{
    Console.WriteLine("Please Try Again");
    goto firstPoint;
}

void ChangeFirstAndLastCharacter(string str)
{
    char first = str[0];
    char last = str[^1];
    string output = last + str.Substring(1, str.Length - 2) + first;
    Console.Write($"{output} ");
}