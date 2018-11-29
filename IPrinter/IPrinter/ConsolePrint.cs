﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPrinter
{
    class ConsolePrint : IPrinter
    {
        public string text { get; set; }
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
