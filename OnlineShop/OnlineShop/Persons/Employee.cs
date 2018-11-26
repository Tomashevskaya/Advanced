using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Employee : OnlineShop.Persons
    {
        public string Position { get; set; }

        public Employee(string name, string position)
            : base(name)
        {
            Position = position;
        }
        public override void Display()
        {
            Console.WriteLine("Display information about employee: \n {0}, {1}", Name, Position);
        }
    }
}
