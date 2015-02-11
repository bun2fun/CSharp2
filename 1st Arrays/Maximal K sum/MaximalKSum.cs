using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
   Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
    */

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter the number N of the array's elements:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of K elements (it has to be less than N):");
        int k = int.Parse(Console.ReadLine());

        int[] sequence = new int[n];
        int[] result = new int[k];

        for (int i = 0; i < n; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
        }
        sequence = sequence.OrderByDescending(number => number).ToArray();

        Console.WriteLine("The elements with the greatest sum:");
        for (int i = 0; i < k; i++)
        {
            Console.Write(sequence[i] + " ");
        }
    }
}
