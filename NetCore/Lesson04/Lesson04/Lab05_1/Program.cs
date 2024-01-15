namespace Lab05_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a ={
                { 4, 6, 3
                },
                { 5, 7, 4
                },
                { 6, 8, 5
                },
                { 7, 9, 6
                },
            };
            Console.WriteLine("Noi dung mang:");
            for (int i = 0; i < a.GetUpperBound(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < a.GetUpperBound(1); j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Các phần tư có chỉ số hàng bằng chỉ số cột: ");
            for(int i = 0;i < a.GetLength(0); i++)
            {
                for (int j = 0;j < a.GetLength(1); j++)
                {
                    if(i==j)
                        Console.Write(a[i,j]);
                }
            }
            Console.WriteLine("Các phần tử lớn nhất trên hàng");
            for (int i = 0; i < a.GetUpperBound(0); i++)
            {
                int  max = a[i,0];
                for (int j = 0;j <= a.GetUpperBound(1); j++)
                {
                    if(max < a[i,j])
                        max = a[i,j];
                }
                Console.WriteLine("Hang {0}:{1}",i,max) ;
            }
        }
    }
}
