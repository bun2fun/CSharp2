using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */
class BinarySearch
{
    static void Main()
    {
        //input
        Console.WriteLine("Please enter the elements of the array:");
        
        int[] array = Console.ReadLine()
                        .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();
        Console.WriteLine("Please enter the number you are searching for:");
        int number = int.Parse(Console.ReadLine());

        //sort array
        Array.Sort(array);

        int start = 0;
        int end = array.Length - 1;

        //call the method
        int middle = FindIndexOfGivenNumber(array, number, start, end);
        if (middle == -1)
        {
            Console.WriteLine("The index of number {0} is not found", number); 
        }
        else
        {
            Console.WriteLine("The index of number {0} in the sorted array is: {1}", number, middle);
        }
    }

    private static int FindIndexOfGivenNumber(int[] array, int number, int start, int end)
    {  
        //body
        while (start <= end)
        {
            int middle = (start + end) / 2;
            if (array[middle] < number) //if true we are looking for the number in the right half
            {
                start = middle + 1;
                continue;
            }
            else if (array[middle] > number) //if true we are looking for the number in the left half
            {
                end = middle - 1;
                continue;
            }
            else
            {
                return middle;
            }
        }
        return -1; //value not found
    }
}


