using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.
 */

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers of the array on one line separated by ',':");

        int[] sequence = //new int[] { 12, 3, 6, 16, 2, 45, 6, 4, 8 };
                         Console.ReadLine()
                        .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();

        Console.WriteLine("The index of the first larger number is: {0}", ReturnValueFromLargerThanMethod(sequence));
    }

    private static int ReturnValueFromLargerThanMethod(int[] sequence)
    {
        //use the method from the previous task
        if (IsLargerThanNeighbours(sequence) < 0)
        {
            return -1;
        }
        else
        {   
            return IsLargerThanNeighbours(sequence);
        }
    }

    private static int IsLargerThanNeighbours(int[] sequence)
    {
        int currentNumber = 0;
        int position = 0;
        bool leftValue = false;
        bool rightValue = false;

        for (int i = 0; i < sequence.Length; i++)
        {
            currentNumber = sequence[i];
            position = i;
            int leftNeighbour = position - 1;
            int rightNeighbour = position + 1;

            if (position > 0 && position < sequence.Length - 1)
            {
                if (currentNumber > sequence[leftNeighbour])
                {
                    leftValue = true;
                }
                if (currentNumber > sequence[rightNeighbour])
                {
                    rightValue = true;
                }
                if (leftValue == true && rightValue == true)
                {
                    return position;
                }
            }
        }
        return -1;
    }
}
