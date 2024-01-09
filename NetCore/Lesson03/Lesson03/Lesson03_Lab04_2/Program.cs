namespace Lesson03_Lab04_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Student");
            StudentCollege cd = new StudentCollege("Duong", 2002, 10, 10, 10);
            cd.Display();
            Console.Write("sinh vien cao dang : {0}", cd.Average());
            StudentUniversity dh = new StudentUniversity("Huong",2002 ,4,5,8,10);
            dh.Display();
            Console.Write("sinh vien dai hoc : {0}", dh.Average());

        }
    }
}
