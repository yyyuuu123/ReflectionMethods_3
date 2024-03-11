using ReflectionMethods2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionMethods2.Utils
{
    internal static class UtilMethods
    {
        private static void _printToDisplay(Type type)
        {
            Console.Write("Класс: ");
            string className = type.Name;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(className);
            Console.ResetColor();

            
            //get methods of object
            List<MethodInfo> methodInfos = new List<MethodInfo>(type.GetMethods()).FindAll(x => !x.IsSpecialName && x.DeclaringType.Name == className);

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
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{method.Name}()");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(UtilMethods.GetAliasType(method.ReturnType.Name));
                    Console.Write(" ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(method.Name);
                    Console.ResetColor();
                    Console.Write("(");

                    for (int i = 0; i < methodArgs.Count; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{UtilMethods.GetAliasType(methodArgs[i].ParameterType.Name)}");
                        Console.ResetColor();
                        Console.Write(" ");
                        Console.Write(methodArgs[i].Name);
                        if (i < listLength - 1)
                        {
                            Console.Write(", ");
                        }
                    }

                    Console.Write(")");
                    Console.WriteLine();
                }
            }

        }
        public static string GetAliasType(string type)
        {
            switch (type)
            {
                case "String":
                    return "string";
                case "Int32":
                    return "int";
                case "Void":
                    return "void";
            }

            return "object";
        }

        public static void Print(Type type)
        {
            _printToDisplay(type);
        }
    }
}
