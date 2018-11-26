using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons client = new Client("Roman Tkachev", 50);
            Persons employee = new Employee("Alexey Kazakov", "Senior manager");
            client.Display();
            employee.Display();
            Console.ReadLine();
        }
    }
}

