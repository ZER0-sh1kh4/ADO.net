//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using BusnisessList;
BusinessClass business = new BusinessClass();

List<string> result = business.reverse();
foreach (var name in result)
{
    Console.WriteLine(name);
}

Console.ReadLine();