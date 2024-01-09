namespace Lesson03_Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Window win = new Window(1,2);

            ListBox lb = new ListBox(3, 4, "BoxBox");

            Button b = new Button(5, 6);

            win.DrawWindow();
            lb.DrawWindow();
            b.DrawWindow();
            Window[] winArry = new Window[3];
            winArry[0] = new Window(1,2);
            winArry[1] = new ListBox(3,4,"Box Box");
            winArry[2] = new Button(5,6);
            for (int i = 0; i < 3; i++)
            {
                winArry[i].DrawWindow();
            }
        }
    }
}
