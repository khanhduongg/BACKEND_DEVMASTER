namespace Lesson02_01Theory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Ngôn ngữ lập trình C# :
                +Biến , Hằng , toán tử , toán hạng , biểu thức ,câu lệnh,khối lệnh
             I/O : Console
                + Input : Read,Readline,Readkey
                + Output: Write / WriteLine
             Cấu trúc điều khiển ( 3 loại)
                + Lựa chọn / rẽ nhánh
                    ++ if ( 4 dạng )
                        - if đơn
                                if(condition){
                                  statement };

                        - if đầy đủ
                        - if bậc thang
                        - if lồng nhau
                    ++ switch 
                            switch ( expression) {
                                case value :
                                    statement ;
                                    break ;
                                .....
                            }
                        
                + Loop
                    ++ for 4 cú pháp khác nhau
                        
                    ++ While 
                    
                    ++ do..while

                    ++ foreach
                    
                + Lệnh nhảy
                    ++ breal ;
                    ++ continue ;
                    ++ return ;
                    ....

             */
           Console.WriteLine("Demo !");
         //   // khởi tạo đối tượng
         //   Category cat = new Category();
         //   //truy cập đến thuộc tính
         //   cat.Id = 1;
         //   cat.Name = "Devmaster";
         //   //truy cập phương thức
         //   cat.Display();
         //
         Employes a = new Employes();
            a.Id = 1;
            a.FullName = "test";
            a.Salary = "abc";
            a.Display();
            // tạo trong employees -> khởi tạo có 
            // 3 tham số
         // sử dụng
            a = new Employes(222,"Duong Duong","abc");
            a.Display();
            // test calculator 
            int kq = Calculator.Add(10, 20);
            Console.WriteLine(kq);
            kq = Calculator.Sub(10,20);
            Console.WriteLine(kq);
            // kq kq = Calculator.mul(10,20); error
            Calculator calc = new Calculator();
            kq = calc.Mul(10, 20);
            Console.WriteLine(kq);
            // ref /out
            int cong, tru;
            calc.Calc(10,20, out cong , out tru);
            Console.WriteLine("Cong:" +cong);

            int num1 = 100, num2 = 200;
            Console.WriteLine("num1:{0} / num2:{1}" ,num1 ,num2);
        }
    }
}
