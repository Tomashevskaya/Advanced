using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileChat
{
    class Chat
    {
        public static void Chatting()
        { 
                FileInfo file = new FileInfo(@"d:\Chat.txt");
                FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    for (int i = 0; i< 5; i++)
                    {
                        Console.Write("USer1: ");
                        string temp1 = Console.ReadLine();
                        Console.Write("USer2: ");
                        string temp2 = Console.ReadLine();
                        sw.WriteLine($"User1: {temp1}");
                        sw.WriteLine($"User2: {temp2}");
                    }
            sw.Close();
        }
    }
}
