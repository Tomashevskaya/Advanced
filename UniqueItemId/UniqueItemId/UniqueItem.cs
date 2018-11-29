using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueItemId
{
    public class Student
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        private static int NextId { get; set; }

        static Student()
        {
            if (true)
            {
                NextId = 1000000;
            }
            else
            {
                NextId = 0;
            }
        }

        public Student()
        {
            Id = NextId;
            NextId++;
        }
    }
}
