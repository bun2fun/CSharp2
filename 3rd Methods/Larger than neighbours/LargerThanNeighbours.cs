using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
 */

class LargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers of the array on one line separated by ',':");

        int[] sequence = //new int[] { 12, 3, 6, 16, 2, 45, 6, 4, 8 };
                         Console.ReadLine()
                        .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();

        Console.WriteLine("Enter the number you would like to check:");
        int number = int.Parse(Console.ReadLine());

        if (IsLargerThanNeighbours(sequence, number))
        {
            Console.WriteLine("{0} is larger than its neighbours!", number);
        }
        else
        {
            Console.WriteLine("{0} is not larger than its neighbours!", number);
        }
    }

    private static bool IsLargerThanNeighbours(int[] sequence, int number)
    {
        int position = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] == number)
            {
                position = i;
                break;
            }
        }
        int leftNeighbour = position - 1;
        int rightNeighbour = position + 1;
        bool leftValue = false;
        bool rightValue = false;

        if (position > 0 && position < sequence.Length - 1)
        {
            if (number > sequence[leftNeighbour])
            {
                leftValue = true;
            }
            if (number > sequence[rightNeighbour])
            {
                rightValue = true;
            }
            if (leftValue == true && rightValue == true)
            {
                return true;
            }
        }
        else if (position == 0)
        {
            if (number > sequence[rightNeighbour])
            {
                rightValue = true;
                return true;
            }
        }
        else if (position == sequence.Length - 1)
        {
            if (number > sequence[leftNeighbour])
            {
                leftValue = true;
                return true;
            }
        }
        return false;
    }
}
