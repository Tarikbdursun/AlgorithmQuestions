// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

startPoint:
Console.WriteLine("Give An Input:");
string? input = Console.ReadLine();
int charNumber;

try
{
    string[] shreddedParts = input.Split(',', 2);
    int.TryParse(shreddedParts[1], out charNumber);
    string word = shreddedParts[0];
    string result=word.Remove(charNumber,1);
    Console.WriteLine(result);
}
catch (Exception e)
{
    Console.WriteLine("Wrong Input Please Try Again");
    goto startPoint;
}