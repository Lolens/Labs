using System;
public class Program

{
    public static void Main()
    {
        int[] A = new int[30];
        var rand = new Random();
        for (int i = 0; i < 30; i++) // Заполняем в цикле массив случайными числами от 0 до 100
            A[i] = rand.Next(0, 100);
        int kolichestvo, summa;
        kolichestvo = 0;
        summa = 0;
        for (int i = 0; i < 30; i++) // Цикл по элементам массива
        {
            if ((A[i] % 5) == 0)
            {
                    kolichestvo = kolichestvo + 1;
                    summa = summa + A[i];       
            }
        }
        Console.Write("Сумма: ");
        Console.Write(summa);
        Console.Write(" Количество: ");
        Console.Write(kolichestvo);
    }
}