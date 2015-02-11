using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
 */
class MaximalSequence
{
    static void Main()
    {

        Console.WriteLine("Please enter the elements of the array: ");
        string[] input = Console.ReadLine().Split(',');
        
        int count = 1;
        int maxCount = 1;
        bool isEqual = false;

        int[] sequence = new int[input.Length];
        int maxNumber = 0;

        for (int i = 0; i < input.Length; i++)
        {
            sequence[i] = Convert.ToInt32(input[i]);
        }
        for (int i = 1; i < sequence.Length; i++)
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
        //Console.WriteLine(maxCount);
        for (int i = 0; i < maxCount; i++)
        {
            if (i == maxCount - 1)
            {
                Console.WriteLine(maxNumber);
            }
            else
            {
                Console.Write("{0}, ", maxNumber);
            }
            
        }
    }
}
