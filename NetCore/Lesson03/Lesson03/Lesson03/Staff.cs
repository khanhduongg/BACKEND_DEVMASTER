using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Theory
{
    internal class Staff :Preson
    {
        public float Salary { get; set; }
        // kế thừa constructor
        public Staff() { }
        public Staff(int id, string name, string address, string phone ,float salary,float baseSalary) 
        
            :base(id,name, address, phone, baseSalary)
        {
            Salary = salary;
        }
        public void printInfo() {
            //Console.WriteLine("ID :{0}", Id);
            //Console.WriteLine("Name :{0}", Name);
            //Console.WriteLine("Addresss :{0}", Address);
            //Console.WriteLine("Phone :{0}", Phone);
            base.printInfo();
            Console.WriteLine("Salary :{0}", Salary);
        }
        // khái niệm ghi đè phương thức Overridingg (polymorphism)
        public override float GetBaseSalary()
        {
            return base.GetBaseSalary() +BaseSalary;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("| {0} ",GetBaseSalary());
        }
    }
}
