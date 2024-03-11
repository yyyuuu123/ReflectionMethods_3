// See https://aka.ms/new-console-template for more information
using ReflectionMethods2.Model;
using ReflectionMethods2.Utils;
using System.Reflection;
using System.Text.RegularExpressions;



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

Regex regex = new Regex(@"\b\w+\b");
MatchCollection matches = regex.Matches(inputUser);

if(matches.Count > 0)
{
    string asseblayName = Assembly.GetExecutingAssembly().GetName().Name;

    Type typeClass = Type.GetType($"{asseblayName}.Model.{matches[0].Value}");

    for (int i = 2; i < matches.Count; i++)
    {
        Console.WriteLine(matches[i]);
    }
}

MethodInfo[] methods = typeCar.GetMethods();
