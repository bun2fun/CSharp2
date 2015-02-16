using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Binary search

Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
 */

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter the number of integers:");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer K:");
        int K = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the integers on separate lines:");
        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);

        while ( Array.BinarySearch(array, K) < 0)
        {
            K--;
        }
        int position = Array.BinarySearch(array, K);
        Console.WriteLine("The largest number <= K is:");
        Console.WriteLine(array[position]);
    }
}
