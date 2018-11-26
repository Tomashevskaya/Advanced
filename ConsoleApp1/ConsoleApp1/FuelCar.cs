using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class FuelCar
    {
        public int Engine { get; set; }
        
        public static bool operator <(FuelCar c1, FuelCar c2)
        {
            return c1.Engine < c2.Engine;
        }

        public static bool operator >(FuelCar c1, FuelCar c2)
        {
            return c1.Engine > c2.Engine;
        }
        
        public static bool operator ==(FuelCar c1, FuelCar c2)
        {
            return c1.Engine == c2.Engine;
                
        }

        public static bool operator !=(FuelCar c1, FuelCar c2)
        {
            return c1.Engine != c2.Engine;
        }
    }
}

