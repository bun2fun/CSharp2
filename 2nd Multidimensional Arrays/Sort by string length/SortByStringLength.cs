using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
 */
class SortByStringLength
{
    static void Main()
    {
        Console.WriteLine("Enter the number of strings:");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];

        Console.WriteLine("Enter the strings on separate rows:");
        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }
        Console.WriteLine();
        Console.WriteLine("The sorted array:");
        // call the method
        array = SortStringArrayByLength(array);
    }

    private static string[] SortStringArrayByLength(string[] array)
    {
        Array.Sort(array);
        array = array.OrderBy(word => word.Length).ToArray();

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        return array;
    }
}