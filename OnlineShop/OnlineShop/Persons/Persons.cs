using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal abstract class Persons
    {
        public string Name { get; set; }

        public Persons(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
    }
}