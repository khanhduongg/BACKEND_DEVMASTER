using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Lab04_5
{
    internal class Car : IMovable
    {
        private bool started = false;
        public void Start()
        {
            Console.WriteLine("Car Started");
            started = true; 
        }
        public void Stop()
        {
            Console.WriteLine("Car Stoped ");
            started = false;
        }
        public bool Started
        {
            get { return started; }
        }
        public void TurnLeft()
        {
            Console.WriteLine("Car Turning left");
        }
        public void TurnRight()
        {
            Console.WriteLine("Car Turning Right");
        }
        public void Accelearate()
        {
            Console.WriteLine("Car Aceelerateing"); 
        }
        public void Brake()
        {
            Console.WriteLine("Car Brakeing");
        }
    }
}
