using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueItemId
{
    public partial class Program
    {
        static List<Student> _students = new List<Student>();

        public static void Main(string[] args)
        {
            var student1 = new Student() { Name = "Ivan" };
            var student2 = new Student() { Name = "Ivan" };
            _students.Add(student1);
            _students.Add(student2);
            for (var i = 0; i < 100; i++)
            {
                _students.Add(new Student() { Name = i.ToString() });
            }
            foreach (var student in _students)
            {
                Console.WriteLine($"{student.Id}:{student.Name}");
            }

            Console.ReadKey();
        }

        
    }


}
