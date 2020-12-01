using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string newstr = "";
            for (int i = str.Length - 1; i >= 0; i--)
                newstr += str[i];
            Console.WriteLine(newstr);
        }
    }
}
