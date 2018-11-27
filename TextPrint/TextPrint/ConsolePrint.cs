using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextPrint
{
    public class ConsolePrint : Printer
    {
        public override void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
