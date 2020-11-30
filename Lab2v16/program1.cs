using System;

namespace ex1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите y, x, z");
            double y = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            double f;
            f = Math.Pow(y, x) + (Math.Sqrt(Math.Abs(x) + Math.Exp(y))) - (Math.Pow(z, 3) * Math.Pow(Math.Sin(y),2)) / (y + Math.Pow(z, 2) / (y - x));
            Console.WriteLine(f);
            Console.ReadKey();    
        }
    }
}
