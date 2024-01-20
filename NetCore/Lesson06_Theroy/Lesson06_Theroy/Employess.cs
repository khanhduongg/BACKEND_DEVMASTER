using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_Theroy
{
    internal class Employess
    {
        //properties / attribute
        public int EmId { get; set; }
        public string EmpName { get; set; }
        public string EmPhone {  get; set; }
        public double EmSalary { get; set; }
        
        //contructor
        public Employess() { }
        public Employess(int emId, string empName, string Emphone, double emSalary)
        {
            EmId = emId;
            EmpName = empName;
            EmPhone = Emphone;
            EmSalary = emSalary;
        }

        //method
        public override string ToString()
        {
            return string.Format("{0,-5}{1,-15},{2,-15}{3:#.##0.#}" , EmId,EmpName,EmPhone,EmSalary);
        }

    }
}
