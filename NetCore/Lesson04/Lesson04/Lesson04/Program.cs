namespace Lesson04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("Review!");
            //Student student = new Student();
            //Console.WriteLine(student.ToString());
            //student =new Student(111,"Duong Duong","45");
            //student.Display();
            //Console.WriteLine(student.ToString());
            int[] a;
            int[] b =new int[10];
            float[] c = new float[] {1.2f,1.3f,1.4f};
            string[] name = { "Hùng", "Dũng", "Sang" };
            // truy cập phần tử 
            b[0] = 100;
            b[5] = 500;
            Console.WriteLine("b[5]={0}", b[5]);
            //duyện mảng :
            for (int i = 0; i < b.Length; i++) {
                Console.WriteLine("{0,5}",b[i]);

            }
            Console.WriteLine();
            foreach (var item in b) {
                Console.WriteLine("{0,5", item);
            }
            Console.WriteLine();
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Student[] students =
            {
                new Student(1,"Nguyễn Văn D","20"),
                new Student(2,"Nguyễn Văn A","21"),
                new Student(3,"Nguyễn Văn B","22"),
                new Student(4,"Nguyễn Văn C","23"),
                new Student(1,"Nguyễn Văn D","20")
            };
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
            for (int i = 0;i < students.Length;i++)
            {
                for (int j = 0; j < students.Length; j++)
                {
                   // if (students[i].Age < students[j].Age)
                    {

                    }    
                }
            }
        }
    }
}
