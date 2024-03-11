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
        private string _enterprise;
        private string _model;
        private int _year;
        public void PrintInfo()
        {
            string s = _enterprise + " " + _model + " " + _year;
            Console.WriteLine(s);
        }

        public void UpdateModel(string model)
        {

        }

        public void Update(string enterprise, string model, int year)
        {
            _enterprise = enterprise;
            _model = model;
            _year = year;
        }

    }
}
