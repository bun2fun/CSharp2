using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.
*/

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Please enter the values of the first array's items:");
        char[] firstArray = Console.ReadLine().ToCharArray();
        Console.WriteLine("Please enter the values of the second array's items:");
        char[] secondArray = Console.ReadLine().ToCharArray();
        int match = 0;

        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    match++;
                }
            }
            if (match == firstArray.Length)
            {
                Console.WriteLine("The arrays are equal!");
            }
            else
            {
                Console.WriteLine("The arrays are different!");
            }
        }
        else
        {
            Console.WriteLine("The arrays are different!");
        }
    }
}
