using System.Collections;

namespace Lesson05_ArryListObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hello, World!");
            ArrayList arr = new ArrayList();
            arr.Add(new Students(111,"Chung",45));
            Students[] st =
            {
                new Students(12,"Chung",5),
                new Students(123,"Huong",25),
                new Students(){Id=333,Name="Huong Huong",Age=21},
                new Students(124,"Duong",15)
            };
            arr.AddRange(st);
            PrintObject(arr);


            // sắp theo thứ tự tuổi tăng dần
            arr.Sort(new SortAgeASC());
            PrintObject(arr);
            // săp theo tên giảm dần
            arr.Sort(new SortNameDESC());
            PrintObject(arr);
            // hastable
            Hashtable ht = new Hashtable();
            Students st1 = new Students(123,"Chung Trinh",100);
            ht.Add(st1.Id, st1);
            st1 = new Students(124, "Chung Trinh 1", 50);
            ht.Add(st1.Id, st1);
            foreach ( var key in ht.Keys)
            {
                Console.WriteLine(key + "========" + ht[key].ToString());
            }
            Console.WriteLine("List value");
            foreach ( var item in ht.Keys)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void PrintObject(ArrayList al)
        {
            Console.WriteLine("Danh sach: ");
            foreach(var item in al)
            {
                Console.WriteLine(item.ToString()); 
            }
        }
        class SortAgeASC : IComparer
        {
            public int Compare( object x ,object y )
            {
                Students a = x as Students;
                Students b =  (Students)y;
                return a.Age - b.Age;
            }
        }
        
        class SortNameDESC : IComparer
        {
            public int Compare(object x, object y)
            {
                Students a = x as Students;
                Students b = (Students)y;
                return b.Name.CompareTo(a.Name);
            }
        }
    }
}
