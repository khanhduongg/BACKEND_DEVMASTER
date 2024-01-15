namespace Lesson05_Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SortedList<String,String> listEm = new SortedList<String,String>();
            listEm.Add("E01", "Nguyen Dinh A");
            listEm.Add("E02", "Nguyen Dinh B");
            listEm.Add("E03", "Nguyen Dinh C");
            listEm.Add("E04", "Nguyen Dinh D");
            listEm.Add("E05", "Nguyen Dinh F");
            Console.WriteLine("Danh sach nhan vien :");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }
            // tìm kiếm nhân viên
            Console.WriteLine("Danh sach nhan vien: ");
            foreach(var key in listEm.Keys)
            {
                if (listEm[key].StartsWith(""))
                    Console.WriteLine(key + ":" + listEm[key]);
            }
            listEm.Remove("E04");
            if (!listEm.ContainsKey("E06")) ;
            listEm.Add("E06", "Nguyen Dinh S");
            Console.WriteLine("Danh sach nhan vien xoa them");
            foreach( var key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }

        }
    }
}
