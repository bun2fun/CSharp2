using System;

/*
Merge sort

Write a program that sorts an array of integers using the Merge sort algorithm.

 */
class MergeSort
{
    static void Main()
    {
        Console.WriteLine("Please enter the array's elements:");
        int[] sortArray = { 16, 5, 3, -1, -8, 7, 22, 9, 4 };

        sortArray = MergeSortArray(sortArray);
        Console.WriteLine(string.Join(", ", sortArray));
    }
    private static int[] MergeSortArray(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }
        int middle = arr.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[arr.Length - middle];
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < middle)
            {
                left[i] = arr[i];
            }
            else
            {
                right[i - middle] = arr[i];
            }
        }
        left = MergeSortArray(left);
        right = MergeSortArray(right);

        return Merge(left, right);
    }

    private static int[] Merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];
        int i, j;
        for (i = 0, j = 0; i < left.Length && j < right.Length; )
        {
            if (left[i] < right[j])
            {
                result[i + j] = left[i];
                i++;
            }
            else
            {
                result[i + j] = right[j];
                j++;
            }
        }
        for (; i < left.Length; i++)
        {
            result[i + j] = left[i];
        }
        for (; j < right.Length; j++)
        {
            result[i + j] = right[j];
        }
        return result;
    }
}