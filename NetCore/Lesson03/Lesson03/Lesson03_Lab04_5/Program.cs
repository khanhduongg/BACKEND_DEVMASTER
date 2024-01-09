namespace Lesson03_Lab04_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            Console.WriteLine("Calling my car :");
            mycar.Start();
            Console.WriteLine("Calling my car.TurnLeft()");
            mycar.TurnLeft();

        }
    }
}
