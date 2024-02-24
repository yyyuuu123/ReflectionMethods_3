// See https://aka.ms/new-console-template for more information
using ReflectionMethods2.Model;
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
    List<string> args1 = methodArgs.ConvertAll(x => $"{x.ParameterType.Name} {x.Name}");

    if (methodArgs.Count > 0)
    {
        foreach (ParameterInfo param in methodArgs)
        {
            Console.Write(method.Name);
            Console.Write("(");
            Console.Write(param.ParameterType.Name);
            Console.Write(" ");
            Console.Write(param.Name);
            Console.Write(")");
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine($"{method.Name}()");
    }
}



Console.WriteLine();
Console.WriteLine();