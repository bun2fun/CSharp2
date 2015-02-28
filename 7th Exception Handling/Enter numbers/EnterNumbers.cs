using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Enter numbers

Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

class EnterNumbers
{
    static void Main()
    {
        int min = 1;
        int max = 100;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter number in range [{0};{1}]", min, max);
            try
            {
                int number = ReadNumber(min, max);
                min = number;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }

    private static int ReadNumber(int min, int max)
    {
        int number = int.Parse(Console.ReadLine());

        if (number <= min || number >= max)
        {
            throw new ArgumentOutOfRangeException();
        }

        return number;
    }
}

