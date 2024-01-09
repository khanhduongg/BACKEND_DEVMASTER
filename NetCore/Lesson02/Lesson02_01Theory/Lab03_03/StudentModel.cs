using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_03
{
    public class StudentModel
    {
        List<Student> liststudent;
        // phương thức khởi tạo
        public StudentModel()
        {
            this.liststudent = new List<Student>
            {
            new Student() { Id = 1, Name = "Duong", Age = "22" },
            new Student() { Id = 2, Name = "Huong", Age = "21" },
            new Student() { Id = 3, Name = "Ha", Age = "22" },
            new Student() { Id = 4, Name = "Tuan", Age = "23" },
            new Student() { Id = 5, Name = "Chun", Age = "24" },
            };
        }
        // phương thức trả về sinh viên
        #region
       public List<Student> GetStudent()
        {
            return liststudent;
        }
        public Student GetStudent(int id)
        {
            Student st = null;
            foreach(var item in liststudent)
            {
                if (item.Id == id)
                {
                    st = item;
                }
                return st;
            }
        }
        // phương thức trả về sinh viên có tuổi từ x to y
        public List<Student> GetStudent(int x , int y)
        {
            List<Student> result = new List<Student>();
            foreach (var item in liststudent)
            {
                if (item.Age >= x && item.Age <= y)
                    result.Add(item);
            }
            return result;
        }
        #endregion
    }
}
