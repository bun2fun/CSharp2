using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
 */

class AppearanceCount
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers of the array on one line separated by ',':");

        int[] sequence = //new int[] { 2, 3, 6, 16, 2, 45, 6, 4, 8, 8 };
                         Console.ReadLine()
                        .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();

        Console.WriteLine("Enter the number you would like to check:");
        int number = int.Parse(Console.ReadLine());


        Console.WriteLine("The number of times {0} is repeated in the array is: {1}", 
                            number, TimesNumberRepeatedInArray(sequence, number));
    }

    private static int TimesNumberRepeatedInArray(int[] sequence, int number)
    {
        int counter = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
}

