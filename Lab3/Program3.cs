using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, x, y;
            Console.WriteLine("Введите x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = Convert.ToDouble(Console.ReadLine()); 
            a = (2 * Math.Sin(x)+(1/2)*Math.Cos(y));
            Console.WriteLine(a);
        }
    }
}
