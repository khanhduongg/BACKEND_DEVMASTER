using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Lab04_2
{
     internal class StudentCollege : Student
    {
        protected double score1,score2,score3;
        //contructor
        public StudentCollege(string name,int year,double score1, double score2, double score3)
        : base(name, year)
        {
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }
        public override double Average()
        {
            return (score1+score2+score3) / 3;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("score1 :{0:N}", score1);
            Console.WriteLine("Score2: {0:N} ", score2);
            Console.WriteLine("Score3: {0:N} ", score3);

        }
    }
}
