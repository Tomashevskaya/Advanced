using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessType
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessType("Hello");
            GuessType(23);
            GuessType(3.14);
            DateTime time = DateTime.Now;
            GuessType(time);
            GuessType('a');
            Console.ReadKey();
        }

        public static void GuessType<T>(T item)
        {
            switch (item)
            {
                case string str:
                    {
                        Console.WriteLine($"You past string with lenght {str.Count()}");
                        break;
                    }
                case int number:
                    {
                        Console.WriteLine($"You past number {number}");
                        break;
                    }
                case double x:
                    {
                        Console.WriteLine($"You past double number {x}");
                        break;
                    }
                case DateTime x:
                    {
                        Console.WriteLine($"You past time {x}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Unknown type");
                        break;
                    }
            }
        }
    }
}
