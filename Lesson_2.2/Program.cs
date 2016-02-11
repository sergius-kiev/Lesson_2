using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> At the time:");
            Console.ReadKey();
            Console.WriteLine(System.DateTime.Now.ToLongTimeString());
            Console.ReadKey();

        }
    }
}
