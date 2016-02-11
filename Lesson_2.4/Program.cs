using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int n;
            Console.WriteLine("Hello! Let's go to create random array!!1 11");

            Random rnd = new Random();
            int n = 5 + rnd.Next(10);
            //n = Convert.ToInt16(Console.ReadLine());
            //double[] Data = new double[n];
            Random R = new Random();
            byte[] arra = new byte[n];
            R.NextBytes(arra);
            foreach (var i in arra)
            {
                Console.Write("{0} ", i);
                Console.WriteLine();
                //Console.ReadKey();
                //return 0;
            }
            Console.ReadKey();
            Console.WriteLine("How much element of array?");
            Console.WriteLine(arra.Length);
            Console.ReadKey();
        }
    }
}
