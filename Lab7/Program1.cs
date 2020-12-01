using System;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        static void Main()

        {
            Console.WriteLine("Введите имя");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите фамилию");
            String surname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите отчество");
            StringBuilder Middlename = new StringBuilder(Console.ReadLine());
            int str1 = name.Length;
            int str2 = surname.Length;
            int str3 = Middlename.Length;
            string strok = name + " " + surname + " " + Middlename;

            char ch1 = surname[1];
            int i;
            int kol = -1;
            for (i = 0; i < strok.Length; i++)
            {
                if (strok[i] == ch1)
                {
                    kol++;

                }
            }
            for (i = 0; i < Middlename.Length; i++)
            {
                if (Middlename[i] == 'е' || Middlename[i] == 'а' || Middlename[i] == 'ё' || Middlename[i] == 'и' || Middlename[i] == 'у' || Middlename[i] == 'ы' || Middlename[i] == 'я' || Middlename[i] == 'о' || Middlename[i] == 'э' || Middlename[i] == 'ю')
                {
                    Middlename[i] = char.ToUpper(Middlename[i]);

                }
            }
            Console.WriteLine("Количество повторений второй буквы фамилии =" + kol);
            Console.WriteLine("Изменённое отчество = " + Middlename);
            Console.WriteLine("Количество символов в строке = {0} {1} {2}", str1, str2, str3);
            Console.WriteLine("2 буква фамилии " + ch1);
            Console.WriteLine(strok);
            Console.ReadKey();


        }
    }
}