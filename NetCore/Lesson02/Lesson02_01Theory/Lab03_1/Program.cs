namespace Lab03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car myCar = new car();
            // gán giá trị cho các trường đối tượng
            myCar.make = "Lexus";
            myCar.model = "LX570";
            myCar.color = "white";
            myCar.year = 2023;

            // hiển thị thông tin về đối tượng myCar
            System.Console.WriteLine("Thong tin chi tiet");
            System.Console.WriteLine("Make : " + myCar.make);
            System.Console.WriteLine("Model: " + myCar.model);
            System.Console.WriteLine("Color: " + myCar.color);
            System.Console.WriteLine("Year release: " +myCar.year);
            // gọi các phương thức
            myCar.start();
            myCar.stop();
        }
    }
}
