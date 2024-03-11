// See https://aka.ms/new-console-template for more information
using ReflectionMethods2.Model;
using ReflectionMethods2.Utils;
using System.Reflection;



//Get Type of object
Type typeCar = typeof(Car);
Type typeBook = typeof(Book);

Console.WriteLine("Доступные классы и методы:");

UtilMethods.Print(typeCar);
UtilMethods.Print(typeBook);

Console.WriteLine();
Console.WriteLine();

Console.Write("Введите команду: ");
string inputUser = Console.ReadLine();
