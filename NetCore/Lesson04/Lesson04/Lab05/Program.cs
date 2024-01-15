namespace Lab05
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] m = { 1, 2, 3 ,4,5,6,1,2,7,9};
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine(m[i]);
            }
            int max = m[0];
            for (int i = 1; i < m.Length; i++)
            {
                if (m[i] > max)
                    max = m[i];
            }
            Console.WriteLine("Phần tử lớn  nhất:" +max);
            // kiểm tra đối xứng
            bool kt = true;
            for (int i = 0;i < m.Length/2;i++) {
                if (m[i] != m[m.Length - 1 -i])
                {
                    kt = false;
                    break;
                }    
            }   if (kt)
            {
                Console.WriteLine("Mang đối xứng");

            }
            else
            {
                Console.WriteLine("Mảng không đối xứng");
            }

        }
    }
}
