using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).
 */
class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Please type the first text input for comparison: ");
        string input1 = Console.ReadLine();
        Console.WriteLine("Please type the second text input for comparison: ");
        string input2 = Console.ReadLine();
        Console.WriteLine();

        char[] firstText = input1.ToCharArray();
        char[] secondText = input2.ToCharArray();

        int length = firstText.Length;
        int match = 0;
        
        //the length of the arrays is equal
        if (firstText.Length == secondText.Length)
        {
            for (int i = 0; i < firstText.Length; i++)
            {
                if (firstText[i] == secondText[i])
                {
                    match++;
                }
                else
                {
                    if (firstText[i] < secondText[i])
                    {
                        Console.WriteLine("The first array is before the second!");
                        break;
                    }
                    else if (secondText[i] < firstText[i])
                    {
                        Console.WriteLine("The second array is before the first!");
                        break;
                    }
                }
            }
            if (match == firstText.Length)
            {
                Console.WriteLine("The two arrays are equal!");
            }
        }
        //the first array is smaller
        else if (firstText.Length < secondText.Length)
        {
            for (int i = 0; i < firstText.Length; i++)
            {
                if (firstText[i] == secondText[i])
                {
                    match++;
                }
                else
                {
                    if (firstText[i] < secondText[i])
                    {
                        Console.WriteLine("The first array is before the second!");
                        break;
                    }
                    else if (secondText[i] < firstText[i])
                    {
                        Console.WriteLine("The second array is before the first!");
                        break;
                    }
                }
            }
            if (match == firstText.Length)
            {
                Console.WriteLine("The first array is before the second!");
            }
        }
        // the second array is smaller
        else if (secondText.Length < firstText.Length)
        {
            for (int i = 0; i < secondText.Length; i++)
            {
                if (firstText[i] == secondText[i])
                {
                    match++;
                }
                else
                {
                    if (secondText[i] < firstText[i])
                    {
                        Console.WriteLine("The second array is before the first!");
                        break;
                    }
                    else if (firstText[i] < secondText[i])
                    {
                        Console.WriteLine("The first array is before the second!");
                        break;
                    }
                }
            }
            if (match == secondText.Length)
            {
                Console.WriteLine("The second array is before the first!");
            }
        }
    }
}

