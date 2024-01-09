using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_03
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public void Dislay() {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age: " + Age);

        }
    }
}
