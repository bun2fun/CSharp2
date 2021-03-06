﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Square root

Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
 */

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a positive integer:");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Invlid number!");
            }
            else
            {
                Console.WriteLine(Math.Sqrt((double)number));
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invlid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too big for integer!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invlid number!");
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }
    }
}

