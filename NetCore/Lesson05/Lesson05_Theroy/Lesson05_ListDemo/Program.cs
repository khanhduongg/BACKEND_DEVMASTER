namespace Lesson05_ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Demo");
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(4);
            list.Add(32);
            list.Add(42);
            list.Add(51);
            Console.WriteLine("\n==================");
            //tăng
            list.Sort();
            // giảm
            list.Sort((x, y) => { return y - x; });
            foreach (var item in list)
            {
                Console.Write("{0,5}", item);
            }
            //object
            List<Students> students = new List<Students>()
            {
                new Students(12,"Chung",5),
                new Students(123,"Huong",25),
                new Students(){Id=333,Name="Huong Huong",Age=21},
                new Students(124,"Duong",15)
            };
            // sắp tăng theo tuổi
            students.Sort((a,b)=> { return a.Age-b.Age;});
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }


        }
    }
}
