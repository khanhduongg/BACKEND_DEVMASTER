namespace Lesson06_Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // tao moi doi tuong House trong namespace Business
           Business.House h = new Business.House();
            h.HouseNo = "D294FF";
            h.Price = 100;
            Console.WriteLine(h.HouseNo);
            Console.WriteLine(h.Price);
            Business.Dealership.car c = new Business.Dealership.car();
            c.CarNo = "A0000";
            c.Price = 100;
            Console.WriteLine(c.CarNo);
            Console.WriteLine(c.Price);
        }
    }
}
