using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Reverse number

Write a method that reverses the digits of given decimal number.
Example:

input	output
256	    652
 */

class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a random integer:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The reversed number is:");
        PrintReversedNumber(number);
    }

    private static void PrintReversedNumber(int number)
    {
        string input = Convert.ToString(number);
        int length = input.Length;
        int[] result = new int[length];

        for (int i = 0; i < input.Length; i++)
        {
            result[i] = number % 10;
            number = number / 10;
        }
        foreach (var item in result)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}

