namespace Lesson05_Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
                new Student{Id=1, Name="Nguyen Dinh A", Description="Ha Noi",Avg=9.2},
                new Student{Id=2, Name="Nguyen Dinh B", Description="Ha Noi",Avg=8.2},
                new Student{Id=3, Name="Nguyen Dinh C", Description="Ha Noi",Avg=7.2},
                new Student{Id=4, Name="Nguyen Dinh D", Description="Ha Noi",Avg=6.2},
                new Student{Id=5, Name="Nguyen Dinh E", Description="Ha Noi",Avg=5.2},
                new Student{Id=6, Name="Nguyen Dinh F", Description="Ha Noi",Avg=4.2}
            };
            Console.WriteLine("Danh sach sinh vien");
            foreach (var item in list)
            {
                    Console.WriteLine(item);
            }
            double max = list[0].Avg;
            Student stAvgmax = list[0];
            foreach (var st in list)
            {
                if(st.Avg > max)
                {
                    max = st.Avg;
                    stAvgmax = st;
                }
            }
            Console.WriteLine("Sinh vien co diem cao nhat");
            Console.Write(stAvgmax);
        }
    }
}
