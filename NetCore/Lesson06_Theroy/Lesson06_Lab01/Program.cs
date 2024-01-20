using Store;
namespace Lesson06_Lab01
{
     class Program
    {
        static void Main(string[] args)
        {
            Supply.ManuFactuner dealer = new Supply.ManuFactuner();
            // gan gia  tri
            dealer.Name = "Test";
            dealer.Email = "Test123@gmail.com";
            dealer.Phone = "1234567890";
            //in thong tin
            Console.WriteLine(dealer.Name);
            Console.WriteLine(dealer.Email);
            Console.WriteLine(dealer.Phone);
            //tao moi san pham
            StoreItem si = new StoreItem();
            si.ItemId = 1;
            si.ItemName = "Test";
            si.ItemPrice = 80.00m;
            //in thong  thin
            Console.WriteLine(si.ItemId);
            Console.WriteLine(si.ItemName);
            Console.WriteLine(si.ItemPrice);
            Console.Read();

        }
    }
}
