using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new FuelCar { Engine = 23 };
            var c2 = new FuelCar { Engine = 45 };
            bool compare = c1 > c2;
            Console.WriteLine(compare); 
            Console.ReadKey();
        }
    }
}
