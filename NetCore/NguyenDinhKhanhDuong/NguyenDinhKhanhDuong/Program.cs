using System.Collections;
using System.Text;

namespace NguyenDinhKhanhDuong
{
    internal class Program
    {
        static Hashtable studentHashtable = new Hashtable();

        static void Main()
        {
            while (true)
            {
                Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Hiển thị thông tin sinh viên");
                Console.WriteLine("3. Máy tính điểm trung bình");
                Console.WriteLine("4. Thoát");

                Console.Write("Chọn một tùy chọn (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        DisplayStudentInfo();
                        break;
                    case "3":
                        Console.WriteLine("Kết thúc chương trình.");
                        break;
                    case "4":
                        Console.WriteLine("Kết thúc chương trình.");
                        return;
                    default:
                        Console.WriteLine("Tùy chọn không hợp lệ. Hãy chọn lại.");
                        break;
                }
            }
            static void AddStudent()
            {
                Console.WriteLine("Nhập thông tin sinh viên:");

                Student newStudent = new Student();

                Console.Write("StudID: ");
                newStudent.StuId = Convert.ToInt32(Console.ReadLine());

                Console.Write("StudName: ");
                newStudent.StuName = Console.ReadLine();

                Console.Write("StudGender: ");
                newStudent.StuGender = Console.ReadLine();

                Console.Write("StudAge: ");
                newStudent.StuAge = Convert.ToInt32(Console.ReadLine());

                Console.Write("StudClass: ");
                newStudent.StuClass = Console.ReadLine();

                Console.WriteLine("Nhập 3 điểm:");
                newStudent.SetMarkList();
                 newStudent.CalculateAverage();


                studentHashtable.Add(newStudent.StuId, newStudent);
                Console.WriteLine("Thông tin sinh viên đã được lưu vào Hashtable.");
            }

            static void DisplayStudentInfo()
            {
                Console.Write("Nhập StudID để hiển thị thông tin sinh viên: ");
                int studIDToDisplay = Convert.ToInt32(Console.ReadLine());

                if (studentHashtable.ContainsKey(studIDToDisplay))
                {
                    Student studentToDisplay = (Student)studentHashtable[studIDToDisplay];
                    Console.WriteLine("Thông tin sinh viên:");
                    studentToDisplay.PrintInfo();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Không tìm thấy sinh viên với StudID {studIDToDisplay}.");
                }
            }
    }
   }
}
