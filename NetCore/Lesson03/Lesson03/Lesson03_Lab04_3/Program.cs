namespace Lesson03_Lab04_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khởi tạo hình chữ nhật
            Reactangle rec = new Reactangle();
            // nhập dữ liệu
            rec.Inputdata();
            //in thông tin
            Console.WriteLine("Dien tich hinh chu nhat la : {0:N}", rec.Area());
            Console.WriteLine("Chu vi hinh chua nhat la : {0:N}", rec.Circumference());
            // khởi tạo hình tròn
            Circle circle = new Circle();
            //nhập dữ liệu
            circle.Inputdata();
            //in thông tin
            Console.WriteLine("Dien tich hinh tron la: {0:N}",rec.Area());
            Console.WriteLine("Chu vi hinh tron la : {0:N}", rec.Circumference());
        }
    }
}
