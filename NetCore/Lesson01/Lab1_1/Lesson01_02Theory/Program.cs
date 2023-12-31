using System.Text;

namespace Lesson01_02Theory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập xuất với C#");
            int a = 100, b = 200, c;
            c = a+ b;
            Console.WriteLine(a + "+" + b + "=" + c);
            Console.WriteLine("{0} + {1} = {2}", a, b, c);

            // Nhập Read/ Readline
            //string name;
            //int age;
            //Console.WriteLine("Nhap ten :");
            //name = Console.ReadLine();
            //Console.WriteLine("Nhap Tuoi");
            ////age = Convert.ToInt32(Console.ReadLine());
            //age= int.Parse(Console.ReadLine());

            //in
           // Console.WriteLine("welcome to, {0}; \n age:{1}",name, age);
            // Chuyển đổi / Ép kiểu
            double x = 10.59;
            Console.WriteLine("Kiểu số thực {0}" , x);
            int y = (int)x;
            Console.WriteLine("Ép kiểu double sang kiểu int", +y);

            // cấu trúc điều khiển
            // if
            // --------- if đơn
            Console.WriteLine("Nhập vào một số :");
            int n = int.Parse(Console.ReadLine());
            if( n >10 )
            {
                Console.WriteLine("{0} > 10", n);
            }
            // if - else
            // kiểm tra số n là số chẵn hay lẻ
            if(n%2==0 ) {
                Console.WriteLine("N là số chẵn",n);
            } else
            {
                Console.WriteLine( "N là số lẻ" ,n);

            }
            // if - else if --
            // kiểm tra số n la số dương âm hay bằng 0
            if ( n == 0) {
                Console.WriteLine("n là số 0", n);
            }if(n >0)
            {
                Console.WriteLine("n là số dương ", n);
            }
            else
            {
                Console.WriteLine("n là số âm",n);
            }


            // nested if
            // nhập số a, b => giải phương trình bậc 1 với a ,b ax + b = c
            //Console.WriteLine("Nhập gia tri cua a:");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập gia tri cua b:");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập gia tri cua c:");
            //int c = int.Parse(Console.ReadLine());
            //if (a == 0)
            //{
            //    Console.WriteLine("Phương trình vô nghiệm");
            //}if (a != 0) {
            //    Console.WriteLine("Phương trình có nghiệm : {x}=({c}-{b})/a" , a,b,c);
            //}




            // cấu trúc switch
            // nhập một số (1 chữ số) -> đọc thành lời việt
            //int num;
            //Console.WriteLine("num = ");
            //num = int.Parse(Console.ReadLine());
            //switch(num)
            //{
            //    case 0:
            //        Console.WriteLine("Không");
            //        break;
            //    case 1: Console.WriteLine("Một");
            //        break;
            //    case 2: Console.WriteLine("Hai");
            //        break;
            //    case 3: Console.WriteLine("ba");
            //        break;
            //    default: Console.WriteLine("Nhập sai");
            //        break;
            //}
            // lặp for
            //for ( int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("=====khuyết");
            //for (int i = 0; i++) ;
            //{
            //    Console.WriteLine(i);
            //}
            // while
            int z= 0;
            while (z < 10) {
                Console.WriteLine(x);
                z++;
            }
            bool flag = false;
            while (flag = !flag) {
                Console.WriteLine(flag);
            }
            //true
            flag = true;
            while (flag = !flag)
            {
                Console.WriteLine(flag);
            }// không thực hiện

            flag = false;
            while ( !flag)
            {
                Console.WriteLine(flag);
            }// vô hạn
           // .... do, while , foreach
        }

            

    }
}
