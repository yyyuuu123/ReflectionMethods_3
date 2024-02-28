using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionMethods2.Utils
{
    internal static class UtilMethods
    {
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
    }
}
