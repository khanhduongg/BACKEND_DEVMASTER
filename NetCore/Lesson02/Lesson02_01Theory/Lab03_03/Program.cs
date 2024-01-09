namespace Lab03_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentModel action = new StudentModel();
            List<Student> listall  = action.GetStudent();
        }
    }
}
