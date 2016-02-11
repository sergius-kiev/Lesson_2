using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleList = new People[7];

            int massivePosotion = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Your can create seven person");
                Console.WriteLine("Do you want create people? Print Y if you want ");
                var answer = Console.ReadLine();

                if (answer != "Y")
                {
                    break;
                }

                Console.WriteLine("Write name");
                var name = Console.ReadLine();

                Console.WriteLine("Write age");
                var age = Convert.ToInt32(Console.ReadLine());

                if (age > 100 && age < 0)
                {
                    Console.WriteLine("No valid age");
                    continue;
                }

                Console.WriteLine("Choose gender 0 - male, 1 - feemale");
                var gender = Console.ReadLine();
                Gendre genderType;

                switch (gender)
                {
                    case "1":
                        genderType = Gendre.Female;
                        break;
                    case "2":
                        genderType = Gendre.Male;
                        break;
                    default:
                        Console.WriteLine("Unknown gender type");
                        continue;
                }

                var person = new People(age, name, genderType);
                peopleList[massivePosotion] = person;

                massivePosotion++;
                if (massivePosotion > 6)
                {
                    Console.WriteLine("Massive is full");
                    break; ;
                }
            }

            SortByAge(peopleList);

            foreach (var people in peopleList)
            {
                if (people != null)
                {
                    people.GetInfo();
                }
            }

            Console.ReadKey();
        }

        static void SortByAge(People[] peopls)
        {
            int length = peopls.Length;
            for (int i = 0; i < peopls.Length; i++)
            {
                if (peopls[i] == null)
                {
                    length = i;
                    break;
                }
            }
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (peopls[i]._age > peopls[j]._age)
                    {
                        var tempPeople = peopls[j];
                        peopls[j] = peopls[i];
                        peopls[i] = tempPeople;
                    }
                }
            }
        }
    }
}
