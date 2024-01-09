using Lesson03_Theory;

namespace Lesson03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.Display();
            //student = new Student(11,"Chun Chun","6");
            //student.Display();
            //student.Id = 222;
            //student.Name = "Duong Duong";
            //student.Age = "22";
            //student.Display();
            //OverLoadingDemo over = new OverLoadingDemo();
            //int res = over.Sum(10);
            //Console.WriteLine("Tong:{0}={1}",10, +res);
            //res = over.Sum(0,10);
            //Console.WriteLine("Tong:{0},{1}=>{2}",0,10, +res);
            //double kq = over.Sum(10.1f,10.2f);
            //Console.WriteLine("Kq");
            // ======= inheristance:
            Staff staff = new Staff();
            staff.printInfo();
            staff = new Staff(122,"Duong Duong","Phuc Tho","092712122",1000,122.222f);
            staff.printInfo();

            Console.WriteLine(staff.ToString());
        }
        
    }
}
