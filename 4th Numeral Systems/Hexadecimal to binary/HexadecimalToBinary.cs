using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

/*
Hexadecimal to binary

Write a program to convert hexadecimal numbers to binary numbers (directly).
 */

class HexadecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Please enter a random hexadecimal number:");
        char[] characters = Console.ReadLine().ToCharArray();
        int value = 0;
        int position = 0;
        BigInteger decimalNumber = 0;

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
            decimalNumber += value * (long)Math.Pow(16, position);
            position++;
        }
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
