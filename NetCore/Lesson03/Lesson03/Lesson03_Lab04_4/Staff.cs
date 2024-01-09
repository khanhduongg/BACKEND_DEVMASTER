using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Lab04_4
{
    internal class Staff :IPreson
    {
        // thực thi các phương thức của giao diện
        public void Insert(object obj)
        {
            Console.WriteLine("Da luu dôi tuong : " + obj);

        }
        public void Delete(object obj)
        {
            Console.WriteLine("Da xoa doi tuong : " + obj);

        }
        public void Update(object obj)
        {
            Console.WriteLine("Da cap nhat doi tuong : " + obj);

        }
        public void Display(object obj)
        {
            Console.WriteLine("Thong tin doi tuong : " + obj);

        }

    }
}
