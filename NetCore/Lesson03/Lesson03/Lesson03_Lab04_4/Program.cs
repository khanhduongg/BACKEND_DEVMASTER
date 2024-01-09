namespace Lesson03_Lab04_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo một nhân viên
            IPreson staff = new Staff();
            object data = "Bach Khoa Aptech";
            //gọi các hành động
            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Display(data);
            IPreson student = new Student() { Id = 1, Name = "DuongDuong", Age = 18 };
            // hiển thị dữ liệu
            student.Display(student);
        }
    }
}
