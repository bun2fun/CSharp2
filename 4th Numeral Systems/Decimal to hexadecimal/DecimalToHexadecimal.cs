using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Decimal to hexadecimal

Write a program to convert decimal numbers to their hexadecimal representation.
 */

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter a random decimal number:");
        int number = int.Parse(Console.ReadLine());
        int remainder = 0;
        List<string> decimalValue = new List<string>();

        while (number > 0)
        {
            remainder = number % 16;
            number = number / 16;
            
            // in hexadecimal the remainder can be up to 15
            // case 1: remainders in the range 10-15 have to be converted to letters
            if (remainder > 9)
            {
                // add 55 to remainders > 9 in order to be equal to the values: 65-70 which is A-F
                char symbol = (char)(remainder + 55);
                decimalValue.Add(symbol.ToString());
            }
            // case 2: remainders in the range 0-9
            else if (remainder > 0)
            {
                decimalValue.Add(remainder.ToString());
            }
        }
        decimalValue.Reverse();
        Console.WriteLine("Its hexadecimal representation is:");
        foreach (var item in decimalValue)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}
