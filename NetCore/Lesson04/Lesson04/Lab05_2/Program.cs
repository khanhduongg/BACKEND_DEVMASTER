namespace Lab05_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a =
            {
                {4,6,7 },
                {1,5,3 },
                {2,4,8 },
                {3,2,9 },
            };
            Console.WriteLine("Noi dung mang: ");
            for (int i = 0; i < a.GetUpperBound(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < a.GetUpperBound(1); j++)
                {
                    Console.Write("{0}", a[i,j]);

                }
                Console.WriteLine();
            }   
            Console.WriteLine("Cac phan tu co chi so hang bang cot: ") ;
            for (int i = 0;i < a.GetUpperBound(0); i++)
            {
                for (int j = 0;j < a.GetUpperBound(1);j++)
                {
                    if(i==j)
                        Console.Write("{0}", a[i,j]) ; 
                }    
            } 
            //các phần tử lớn nhất trong mảng
            Console.WriteLine("cac phan tu lon nhat trong mang") ;
            for(int i = 0;i<=a.GetUpperBound(0) ; i++)
            {
                int max = a[i, 0];
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if (max < a[i,j])
                        max = a[i,j];
                }
                Console.Write("Hang {0}:{1}",i,max) ;
            }
        }

    }
}
