using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_1
{
    public class car
    {
        public string make;
        public string model;
        public string color;
        public int year;
        public void start ()
        {
            System.Console.WriteLine(model + "khoi dong");
        }
        public void stop()
        {
            System.Console.WriteLine(model + " dung");
        }
    }
}
