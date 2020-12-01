using System;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApplication65
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double max;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            if (max>c)
            {
                Console.Write(max);
            }
            else
            {
                Console.Write(c);
            }
            if 
            
                Console.Write("Все введённые числа одинаковые");
            }
        }
    }
}