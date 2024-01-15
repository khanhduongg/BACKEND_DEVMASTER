using System.Collections;

namespace Lesson05_Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Product");
            ArrayList arr = new ArrayList();
            arr.Add(new Product("Iphone10", "12", 1));
            arr.Add(new Product("Iphone11", "10", 2));
            arr.Add(new Product("Iphone12", "9", 3));
            arr.Add(new Product("Iphone13", "11", 4));
            arr.Add(new Product("Iphone14", "15", 5));
            Console.WriteLine("List Product");

            foreach (Product p in arr)
            {
                Console.WriteLine(p.ToString());
            }   
        }
        
    }
}
