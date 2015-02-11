using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 */

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Please enter the array's elements:");
        string[] input = Console.ReadLine().Split(',');

        int[] sequence = new int[input.Length];
        int minValue = int.MaxValue;
        int minValueIndex = 0;
        int current = 0;

       
        for (int i = 0; i < input.Length; i++)
        {
            sequence[i] = Convert.ToInt32(input[i]);
        }
        for (int i = 0; i < sequence.Length; i++)
        {
            for (int j = i; j < sequence.Length; j++)
            {
                //finds the min value and its index
                if (sequence[j] < minValue)
                {
                    minValue = sequence[j];
                    minValueIndex = j;
                }
            }
            //preserves the value of the current position 
            //in a varible in order to switch it afterwards
            current = sequence[i];
            sequence[i] = minValue;
            sequence[minValueIndex] = current;
            minValue = int.MaxValue;
        }
        Console.WriteLine("The sorted elements:");
        for (int i = 0; i < sequence.Length; i++)
        {
            Console.Write(sequence[i] + " ");
        }
    }
}