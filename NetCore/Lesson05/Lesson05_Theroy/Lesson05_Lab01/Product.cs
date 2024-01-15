using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_Lab01
{
    internal class Product
    {
        public string Name { get; set; }
        public string Cost { get; set; }
        public int onhand { get; set; }
        public Product(string name, string cost, int onhand)
        {
            Name = name;
            Cost = cost;
            this.onhand = onhand;
        }
        public override string ToString()
        {
            return String.Format("{0,-10}{1,-15}{2,-10}",Name, Cost,onhand);
        }
    }
}
