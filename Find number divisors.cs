using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            
            while (i++ <= N)
            {
                if (N % i == 0)
                {
                    Console.Out.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
