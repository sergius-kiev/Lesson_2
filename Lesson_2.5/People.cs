using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._5
{
    class People
    {
#region Properties
        //private int age;
        //private string name;
        //private Gender gender;

        //public string Name
        //{
        //    get { return name; }
        //    set { this.name = value; }
        //}
        //public int Age
        //{
        //    get { return age; }
        //    set { this.age = value; }
        //}
        //public Gender Gender
        //{
        //    get { return gender; }
        //    set { this.gender = value; }
        //}
#endregion

        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public People()
        {
               
        }
        public People(int age, string name, Gender gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }

        public void GetInfo()
        {
            Console.WriteLine("My name is {0}, I am {1} years old, i am {2}", this.Name, this.Age, this.Gender);
        }
    }

}
