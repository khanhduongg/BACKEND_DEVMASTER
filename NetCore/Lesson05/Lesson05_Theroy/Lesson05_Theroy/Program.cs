using System.Collections;

namespace Lesson05_Theroy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array List Demo");
            // khởi tạo collection ArrayList
            ArrayList array = new ArrayList();
            //properties
            Console.WriteLine("Count:" + array.Count);
            Console.WriteLine("Capacity:" +array.Capacity);
            Console.WriteLine("==========================");
            //Method (add,Addrange,insert,...)
            array.Add("Xin Chao");
            array.Add(100);
            printArrayList(array);
            //insert
            array.Insert(1, "Devmaster");
            printArrayList(array);
            // AddRange/ insertRange
            string[] name = { "Duong", "Tung", "Truc", "Mai" };
            array.AddRange(name);
            printArrayList(array);
            //insert 
            array.InsertRange(0, name);
            printArrayList(array);
            Console.WriteLine("Count:" + array.Count);
            Console.WriteLine("Capacity:" + array.Capacity);
            Console.WriteLine("==========================");
            //xóa :Remove,RemoveAt,Clear;
            array.Remove(100);
            printArrayList(array);
            array.RemoveAt(1);
            printArrayList(array);
            
            // sort/search
            array.Sort(); // sắp tăng
            printArrayList(array);


            // sắp giảm
            array.Sort( new SortDesc());
            printArrayList(array);
        }
        static void printArrayList(ArrayList array)
        {
            Console.WriteLine("===Danh sach phan tu trong mang");
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }
        class SortDesc :IComparer
        {
            public int Compare(object x, object y)
            {
                string a = x as string;
                string b = y as string;
                return b.CompareTo(b);
            }
        }
    }
}
