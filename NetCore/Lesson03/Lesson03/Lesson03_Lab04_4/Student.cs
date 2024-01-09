using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Lab04_4
{
    internal class Student :IPreson
    {
        // khai báo thuộc tính
        public int Id { get; set; }
        public string Name { get; set; }  
        public int Age { get; set; }
        // thực thi phương thức từ giao diện
        public void Insert(object obj)
        {
            Console.WriteLine("Da  luu doi tuong: ", obj);
        }
        public void Delete(object obj)
        {
            Console.WriteLine("Da  xoa doi tuong: ", obj);
        }
        public void Update(object obj)
        {
            Console.WriteLine("Da cap nhat doi tuong: ", obj);
        }
        public void Display(object obj)
        {
            Student st = (Student)obj;
            Console.WriteLine("Id: " + st.Id);
            Console.WriteLine("Name: " +st.Name);
            Console.WriteLine("Age : " +st.Age);
        }
    }
}
