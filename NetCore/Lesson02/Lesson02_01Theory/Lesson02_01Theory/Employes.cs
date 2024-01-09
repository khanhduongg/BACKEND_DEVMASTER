using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_01Theory
{
    // tạo lớp đối tượng employees
    // tạo các thuộc tính tự động
    //   Id,FullName,Salary
    // tạo phương thức printInfor
    // hiển thị thông tin nhân viên
    // test trong Main
    public class Employes
    {
        // khởi tạo các thuộc tính
        public int Id
        { get; set; }
        public string FullName
        { get; set; }
        public string Salary
        { get; set; }
        // constructor
        public Employes() { }
        public Employes(int Id, string FullName, string Salary)
        {
            this.Id = Id;
            this.FullName = FullName;
            this.Salary = Salary;
            }
        public void Display()
        {
            Console.WriteLine("Id\t :" +Id);
            Console.WriteLine("FullName\t:" +FullName);
            Console.WriteLine("Salary\t :" + Salary);
        }
    }
}
