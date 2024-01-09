using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Lab04_3
{
     class Reactangle :Shape
    {
        // phương thức nhập liệu
        public void Inputdata()
        {
            Console.WriteLine("Nhap chieu dai :");
            leghth = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu ngang: ");
            with = int.Parse(Console.ReadLine());
        }
        // ghi đè phương thức diện tích
        public override float Area()
        {
            return leghth * with;
        }
        // ghi đè phương thức tính chu vi
        public override float Circumference()
        {
            return 2 *leghth * with;
        }
    }
}
