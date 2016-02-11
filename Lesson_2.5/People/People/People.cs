using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class People
    {
        public int _age;
        public string _name;
        public Gendre _gendre;

        public People(int age, string name, Gendre gendre)
        {
            _age = age;
            _name = name;
            _gendre = gendre;
        }

        public void GetInfo()
        {
            Console.WriteLine("My name is {0}, I am {1} years old, i am {2}", _name, _age, _gendre);
        }
    }
}
