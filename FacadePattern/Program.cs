//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using FacadePattern;
Console.WriteLine("Child: Mom, I want ice cream!");

IceCreamFacade mother = new IceCreamFacade();

string iceCream = mother.GetIceCream();

Console.WriteLine("Mother gives: " + iceCream);

Console.ReadLine();