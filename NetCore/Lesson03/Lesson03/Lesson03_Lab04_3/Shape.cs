using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Lab04_3
{
    abstract class Shape
    {
        protected float radius, leghth, with;
        // khai báo phương thức trừu tượng
        public abstract float Area(); //tính diện tích
        public abstract float Circumference(); //tính chu vi

    }

}
