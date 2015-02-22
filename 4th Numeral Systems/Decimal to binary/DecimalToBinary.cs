using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Decimal to binary

Write a program to convert decimal numbers to their binary representation.
 */

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Please enter a random decimal number:");
        int decimalNumber = int.Parse(Console.ReadLine());
        List<int> binary = new List<int>();

        while (decimalNumber > 0)
        {
            int remainder = (int)(decimalNumber % 2);
            decimalNumber = decimalNumber / 2;
            binary.Add(remainder);
        }
        binary.Reverse();
        Console.WriteLine("Its binary representation is:");
        foreach (var item in binary)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}
