using ReflectionMethods2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionMethods2.Model
{
    internal class Car : IPrint
    {
        public string PrintInfo()
        {
            return "1";
        }

        public void UpdateModel(string model)
        {

        }

        public void Update(string enterprise, string model, int year)
        {

        }

    }
}
