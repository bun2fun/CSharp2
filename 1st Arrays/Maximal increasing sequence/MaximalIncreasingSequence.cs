using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
*/

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter the elements of the array: ");
        string[] input = Console.ReadLine().Split(',');

        int count = 1;
        int maxCount = 1;
        int startIndex = 0;
        int currentIndex = 0;
        int endIndex = 0;
        bool isGreater = false;

        int[] sequence = new int[input.Length];
        int[] result = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            sequence[i] = Convert.ToInt32(input[i]);
        }
        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] > sequence[i - 1])
            {
                isGreater = true;                
            }
            else
            {
                count = 1;
            }
            if (isGreater == true)
            {
                count++;
                if (count > maxCount)
                {
                    maxCount = count;
                    endIndex = i;
                    startIndex = i - count + 1;
                }
            }
            isGreater = false;
        }
        if (maxCount <= 1)
        {
            Console.WriteLine("No increasing sequence found!");
        }
        else
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (i == endIndex)
                {
                    Console.WriteLine(sequence[i]);
                }
                else
                {
                    Console.Write(sequence[i] + ", ");
                }
            }
        }
    }
}
