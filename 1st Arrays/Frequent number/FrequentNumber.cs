using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Frequent number

Write a program that finds the most frequent number in an array.
 */

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the array's elements:");
        string[] input = Console.ReadLine().Split(',');

        int[] sequence = Array.ConvertAll(input, int.Parse);
        Array.Sort(sequence);

        int count = 0;
        int maxCount = 0;
        int maxNumber = 0;
        bool isEqual = false;

        for (int i = 1; i < sequence.Length - 1; i++)
        {
            if (sequence[i] == sequence[i - 1])
            {
                isEqual = true;
            }
            else
            {
                count = 1;
            }
            if (isEqual == true)
            {
                count++;
                if (count > maxCount)
                {
                    maxCount = count;
                    maxNumber = sequence[i];
                }
            }
            isEqual = false;
        }
        Console.WriteLine("{0} ({1} times)", maxNumber, maxCount);
    }
}

