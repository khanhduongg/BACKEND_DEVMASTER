using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Theory
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dong vat an mot vai thu");

        }
        public void DoSomething () {
            Console.WriteLine("Dong vat lam mot vai thu");
        }
    }
    class Cat:Animal { 
        public void Action()
        {
            Eat();
            DoSomething();
        }
    }
}
