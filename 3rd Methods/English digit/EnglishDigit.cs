using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
English digit

Write a method that returns the last digit of given integer as an English word.
Examples:

input	output
512	two
1024	four
12309	nine
 */

class EnglishDigit
{
    static void Main()
    {
        Console.WriteLine("Enter the integer:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The last digit is:");
        ReturnLastDigitAsWord(number);
    }

    private static void ReturnLastDigitAsWord(int number)
    {
        if (number < 0)
        {
            number *= -1;
        }
        int result = number % 10;
        switch (result)
        {
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
        }
    }
}
