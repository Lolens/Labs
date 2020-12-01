using System;
using System.Text.RegularExpressions;

namespace Pr8
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите сообщение для вставки в него 'Ок', после каждой 'о' ");
            Regex regex = new Regex(@"о(w*)");
            string text = Console.ReadLine();
            string target = "оОк";
            string result = regex.Replace(text, target);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
