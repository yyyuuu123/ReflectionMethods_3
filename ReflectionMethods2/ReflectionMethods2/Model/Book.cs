using ReflectionMethods2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionMethods2.Model
{
    internal class Book : IPrint
    {
        public string PrintInfo()
        {
            throw new NotImplementedException();
        }

        public void SetName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
