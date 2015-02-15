using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Maximal sum

Write a program that finds the sequence of maximal sum in given array.
*/

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Please enter the array's elements:");

        int[] sequence = //new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
                         Console.ReadLine()
                        .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();

        int sum = 0;
        int sequenceStart = 0;
        int sequenceEnd = 0;
        int startPosition = 0;
        int maxSum = 0;


        for (int i = 0; i < sequence.Length; i++)
        {
            //adds the following number in the array to the sum
            sum += sequence[i];
            //disregards the calculation & moves to the next value (if the sum is negative)
            if (sum < 0)
            {
                sum = 0;
                startPosition = i + 1;
            }
            //when max sum is found it saves its value and the first & last index of the sequence
            else if (sum > maxSum)
            {
                maxSum = sum;
                sequenceStart = startPosition;
                sequenceEnd = i;
            }
        }
        for (int i = sequenceStart; i <= sequenceEnd; i++)
        {
            Console.Write(String.Join(", ", sequence[i]));
        }
        Console.WriteLine();
    }
}



