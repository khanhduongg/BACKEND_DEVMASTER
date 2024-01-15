using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    internal class Student
    {
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
        public void Display()
        {
            Console.WriteLine("ID:{0}", + Id);
            Console.WriteLine("Name:{0}", Name);
            Console.WriteLine("Age:{0}", Age);

        }
        public override string ToString()
        {
            return string.Format("{0,5} {1,15} {2,10} ",Id,Name,Age);
        }
       
    }
}
