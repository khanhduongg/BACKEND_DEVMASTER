namespace Lab1_2
{
    internal class Program
    {
        /// <summary>
        /// chương trình minh họa sử dụng biến , hằng số và kiểu dữ liệu
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // khai báo biến
            int id = 1;
            string name = "Duong Duong";
            byte age = 18;
            char gender = 'M';
            // khai báo hằng số
            const float percent = 75.05F;

            Console.WriteLine(" Student Id : {0},",id);
            Console.WriteLine("Student Name : {0}", name);
            Console.WriteLine("Age : ", +age);
            Console.WriteLine("gender :" + gender);
            Console.WriteLine(" percent : {0}", percent);
        }
    }
}
