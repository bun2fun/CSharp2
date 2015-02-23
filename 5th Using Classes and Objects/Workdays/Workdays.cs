using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

/*
Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */

class Workdays
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please enter the date:");
        DateTime futureDate = DateTime.Parse(Console.ReadLine());
       
        Console.WriteLine("Please enter the dates of the public holidays on the following line:");
        List<DateTime> holidays = Console.ReadLine()
                        .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => DateTime.Parse(x))
                        .ToList();
                       
        DateTime start = DateTime.Now;

        int counter = 0;
        for (DateTime date = start; date <= futureDate; date = date.AddDays(1))
        {  
            if (date.DayOfWeek != DayOfWeek.Saturday 
                && date.DayOfWeek != DayOfWeek.Sunday)
            {
                counter++;
            }   
            if (holidays.Contains(date.Date))
            {
                counter--;
            }
        }
        Console.WriteLine(counter);
    }
}

