// See https://aka.ms/new-console-template for more information
using ReflectionMethods2.Model;
using ReflectionMethods2.Utils;
using System.Reflection;

Console.WriteLine("Доступные классы и методы:");

Console.Write("Класс: ");
Console.ForegroundColor = ConsoleColor.Green;

//Get Type of object
Type typeCar = typeof(Car);
string className = typeCar.Name;

Console.WriteLine(className);
Console.ResetColor();

//get methods of object
List<MethodInfo> methodInfos = new List<MethodInfo>(typeCar.GetMethods()).FindAll(x => !x.IsSpecialName && x.DeclaringType.Name == className);

foreach (MethodInfo method in methodInfos)
{
    List<ParameterInfo> methodArgs = new List<ParameterInfo>(method.GetParameters());
    int listLength = methodArgs.Count;

    if (methodArgs.Count == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(UtilMethods.GetAliasType(method.ReturnType.Name));
        Console.Write(" ");
        Console.ResetColor();
        Console.WriteLine($"{method.Name}()");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(UtilMethods.GetAliasType(method.ReturnType.Name));
        Console.Write(" ");
        Console.ResetColor();
        Console.Write(method.Name);
        Console.Write("(");

        for (int i = 0; i < methodArgs.Count ; i++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{UtilMethods.GetAliasType(methodArgs[i].ParameterType.Name)}");
            Console.ResetColor();
            Console.Write(" ");
            Console.Write(methodArgs[i].Name);
            if (i < listLength-1)
            {
                Console.Write(", ");
            }
        }

        Console.Write(")");
        Console.WriteLine();
    }
}



Console.WriteLine();
Console.WriteLine();