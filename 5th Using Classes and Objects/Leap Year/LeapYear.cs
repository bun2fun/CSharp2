using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Leap year

Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.
 */

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Please enter a year:");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} {1} a leap year.", input, (DateTime.IsLeapYear(input)) ? "is" : "is not");
    }
}

