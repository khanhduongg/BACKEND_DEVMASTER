using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Lab04_5
{
    public interface  IDrivable
    {
        // phương thức
        void Start();
        void Stop();
        bool Started
        {
            get;
        }
    }
    public interface ISteerable
    {
        // phương thức
        void TurnLeft();
        void TurnRight();
    }
    public interface IMovable : IDrivable, ISteerable
    {
        //phương thức
        void Accelearate();
        void Brake();
    }
}
