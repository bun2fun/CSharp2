using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Sorting array

Write a method that returns the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
 */

class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers of the array on one line separated by ',':");

        int[] sequence = //new int[] { 2, 3, 6, 16, 2, 45, 6, 4, 8, 8 };
                         Console.ReadLine()
                        .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();

        Console.WriteLine("Enter the starting index of the subarray:");
        int index = int.Parse(Console.ReadLine());

        // create subarray
        int subArrayLenth = sequence.Length - index;
        int[] subArray = new int[subArrayLenth];
        
        for (int i = index; i < sequence.Length; i++)
        {
            subArray[i - index] = sequence[i];
        }

        // descending order
        Console.WriteLine("Descending order:");
        subArray = OrderArrayInDescendingOrder(index, subArray);
        foreach (var item in subArray)
        {
            Console.WriteLine(item);
        }

        // ascending order
        Console.WriteLine("Ascending order:");
        subArray = OrderArrayInAscendingOrder(index, subArray);
        foreach (var item in subArray)
        {
            Console.WriteLine(item);
        }
    }

    private static int[] OrderArrayInDescendingOrder(int index, int[] subArray)
    {
        int number = 0;
        int numberIndex = 0;

        int[] orderedArray = new int[subArray.Length];
        for (int i = 0; i < orderedArray.Length; i++)
        {
            orderedArray[i] = FindGreatestValueInArray(subArray, index);
            number = orderedArray[i];
            numberIndex = Array.IndexOf(subArray, number);
            subArray = subArray.Where((val, inx) => inx != numberIndex).ToArray();
        }
        return orderedArray;
    }

    private static int[] OrderArrayInAscendingOrder(int index, int[] subArray)
    {
        int number = 0;
        int numberIndex = 0;

        int[] orderedArray = new int[subArray.Length];
        for (int i = orderedArray.Length - 1; i >= 0 ; i--)
        {
            orderedArray[i] = FindGreatestValueInArray(subArray, index);
            number = orderedArray[i];
            numberIndex = Array.IndexOf(subArray, number);
            subArray = subArray.Where((val, inx) => inx != numberIndex).ToArray();
        }
        return orderedArray;
    }

    private static int FindGreatestValueInArray(int[] subArray, int index)
    {
        int maxNumber = int.MinValue;
        
        for (int i = 0; i < subArray.Length; i++)
        {
            if (subArray[i] > maxNumber)
            {
                maxNumber = subArray[i];
            }
        }
        return maxNumber;
    }
}