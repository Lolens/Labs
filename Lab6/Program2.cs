using System;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int irecord = 0;
            int jrecord = 0;
            int max = 0;
            Console.WriteLine("Введите размерность массива");
            int n, m;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            Random r = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = r.Next(0, 1000);
                    Console.Write("{0,4} ", a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        irecord = i;
                        jrecord = j;
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == jrecord || i == irecord)
                    {
                        a[i, j] = 0;
                    }
                    Console.Write("{0,4} ", a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}