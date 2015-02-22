using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
Hexadecimal to decimal

Write a program to convert hexadecimal numbers to their decimal representation.
 */

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter a random hexadecimal number:");
        char[] characters = Console.ReadLine().ToCharArray();
        int value = 0;
        int position = 0;
        BigInteger number = 0;

        for (int i = characters.Length - 1; i >= 0; i--)
        {
            char symbol = characters[i];
            // case 1: the symbol is digit in the range 0-9
            if (symbol > 48 && symbol < 58)
            {
                value = symbol - 48;
            }
            // case 2: the symbol is letter A-F
            if (symbol > 64 && symbol < 71)
            {
                value = symbol - 55;
            }
            number += value * (long)Math.Pow(16, position);
            position++;
        }
        Console.WriteLine("Its decimal representation is:");
        Console.WriteLine(number);
    }
}
