using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    internal class Student
    {
        // properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        // contructor
        public Student() { }
        public Student(int id, string name, string age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        //Method
        public void Display() {
            Console.WriteLine("ID:{0}", Id);
            Console.WriteLine("Name:{0}", Name);
            Console.WriteLine("Age:"+ Age);

        }
    }
}
