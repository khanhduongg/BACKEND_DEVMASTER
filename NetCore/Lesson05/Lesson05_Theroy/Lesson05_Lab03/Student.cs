using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_Lab03
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Gender { get; set; }
        public double Avg {  get; set; }
        public override string ToString()
        {
            return "\n" +Id +"\n Name" + Name + "\n" +Description +"\n" + Gender +"\n" + Avg;
        }
    }
}
