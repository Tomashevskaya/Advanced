using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            Console.WriteLine("Выберите способ вывода: \n 1-Вывод на консоль \n 2-Вывод в файл \n 3-Вывод на картинку");
            int answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    ConsolePrint cons = new ConsolePrint();
                    cons.Print(text);
                    break;
                case 2:
                    FilePrint file = new FilePrint();
                    file.Print(text);
                    break;
                case 3:
                    ImagePrint img = new ImagePrint();
                    img.Print(text);
                    break;
                default:
                    Console.WriteLine("Unknown operation!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
