using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Theory
{
     class Preson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public float BaseSalary { get; set; }
        public Preson() { }
        public Preson(int id, string name, string address, string phone, float baseSalary)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            BaseSalary = BaseSalary;
        }
        public void printInfo()
        {
            Console.WriteLine("ID :{0}", Id);
            Console.WriteLine("Name :{0}", Name);
            Console.WriteLine("Addresss :{0}", Address);
            Console.WriteLine("Phone :{0}", Phone);
        }

        //phương thức ghi đè
        public virtual float GetBaseSalary()
        {
            return BaseSalary; 
        }
        public override string ToString()
        {
            return string.Format("{0} | {1} | {2} | {3} | {4}" ,Id,Name,Address,Phone,BaseSalary);
        }
    }
}
