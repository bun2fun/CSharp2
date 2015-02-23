using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Day of week

Write a program that prints to the console which day of the week is today.
Use System.DateTime.
 */

class DayOfWeek
{
    static void Main()
    {
        DateTime today = DateTime.Today;
        Console.WriteLine("Today is {0}", today.DayOfWeek);
    }
}

