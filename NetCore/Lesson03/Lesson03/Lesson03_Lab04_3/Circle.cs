using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Lab04_3
{
     class Circle : Shape
    {
        public void Inputdata()
        {
            Console.WriteLine("Nhap ban kinh: ");
            radius = int.Parse(Console.ReadLine());
        }
        // ghi đè phương thức diện tích
        public override float Area()
        {
            return 3.14F * radius * radius;
        }
        // ghi đè phương thức tính chu vi
        public override float Circumference()
        {
            return 2 * 3.14F * radius;
        }
    }
}
