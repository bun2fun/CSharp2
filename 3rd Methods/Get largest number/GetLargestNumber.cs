using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax(). 
 */

class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("The larger number is:");
        GetMax(number1, number2);
    }

    private static void GetMax(int number1, int number2)
    {
        if (number1 > number2)
        {
            Console.WriteLine(number1);
        }
        else
        {
            Console.WriteLine(number2);
        }
    }
}