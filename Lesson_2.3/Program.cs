using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text;
            Console.WriteLine("Do you want can text?");
            string ansver = Console.ReadLine();
            if (ansver == "yes")
            {
                string text = Console.ReadLine();
                string characters = "answer";
                Console.WriteLine(characters.Length);
                Console.ReadKey();
                Console.WriteLine("Is there symbol 5 in the text?");
                Console.ReadKey();


                if (text.Contains('5'))
                {
                    Console.WriteLine("This text have symbol 5");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("This text not have symbol 5");
                    Console.ReadKey();
                }


                Console.WriteLine("Is there symbol A in the text?");
                Console.ReadKey();
                if (text.Contains('A'))
                {
                    Console.WriteLine("This text have symbol A");
                    Console.WriteLine("text after replace: {0}", text.Replace("A", ""));
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("This text not have symbol A");
                    Console.ReadKey();
                }
                Console.WriteLine("Goodbay");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Goodbay");
                Console.ReadKey();
            }
        }
    }
}
