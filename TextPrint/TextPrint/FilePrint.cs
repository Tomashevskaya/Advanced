using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextPrint
{
    public class FilePrint : Printer
    {
        public override void Print(string text)
        {
            System.IO.File.WriteAllText(@"D:\C#\Lesson2.txt", text);
        }
    }
}
