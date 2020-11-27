using System;

public class DuplicateElement
{
    public static void Main()
    {
        //Initialize array   
        Console.WriteLine("Enter your sentence.");
        string str1 = Console.ReadLine();
        string[] arr = str1.Split(' ');

        Console.WriteLine("Duplicate elements in given array: ");
        //Searches for duplicate element  
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                    Console.WriteLine(arr[j]);
            }
        }
    }
}