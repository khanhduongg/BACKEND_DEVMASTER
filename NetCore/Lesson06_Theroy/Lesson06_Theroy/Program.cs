using System.Text;

namespace Lesson06_Theroy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Employess> list = new List<Employess>()
            {
                new Employess(1,"Nguyen Van A","0912333333",123456.2),
                new Employess(2, "Nguyen Van B", "0912333333", 12346.5),
                new Employess(3, "Nguyen Van C", "0912333333", 123562.1)

            };
            Console.WriteLine("Danh sach nhan vien");
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            // sort
            //list.Sort((x, y) => { return (int)(x.EmSalary - y.EmSalary); });
            list.Sort((x, y) =>
            {
                if (y.EmSalary > x.EmSalary)
                    return 1;
                else if (y.EmSalary < x.EmSalary)
                    return -1;
                return 0;
            });
            Console.WriteLine("Danh sach nhan vien");
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
