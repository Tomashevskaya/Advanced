using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPrinter
{
     class FilePrint : IPrinter
     {
        public string text { get; set; }
        public  void Print(string text)
        {
            System.IO.File.WriteAllText(@"D:\\C#\Lesson2.txt", text);
        }
     }
}
