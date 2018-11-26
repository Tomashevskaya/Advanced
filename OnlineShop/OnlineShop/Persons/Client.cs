using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Client : OnlineShop.Persons
    {
        public int points;
        private int Points
        {
            get { return points; }
            set { points = value; }
        }

        public Client(string name, int pnt)
            : base(name)
        {
            points = pnt;
        }
        public override void Display()
        {
            Console.WriteLine("Display client's statistic: \n {0}, {1} ", Name, points);

        }
    }
}