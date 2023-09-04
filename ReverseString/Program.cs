// See https://aka.ms/new-console-template for more information

Console.Write("Please Give An Input");
string? input;
input=Console.ReadLine();
Console.WriteLine(input);
var result= input.Reverse().ToArray();
Console.WriteLine(new String(result));