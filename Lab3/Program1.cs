using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
                a = a * a * a;
            }
            else
            {
                a = a * a;
            }
            if (b > 0)
            {
                b = b * b * b;
            }
            else
            {
                b = b * b;
            }
            if (c > 0)
            {
                c = c * c * c;
            }
            else
            {
                c = c * c;
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }

    }
}