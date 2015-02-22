using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
/*
binary to hexadecimal

Write a program to convert binary numbers to hexadecimal numbers (directly).
 */

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter a binary number:");
        char[] binaryNumber = Console.ReadLine().ToCharArray();
        BigInteger decimalNumber = 0;
        int position = 0;

        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            int bit = binaryNumber[i] - 48;
            BigInteger bitPower = (BigInteger)Math.Pow(2, position);
            decimalNumber += bit * bitPower;
            position++;
        }
        int remainder = 0;
        List<string> decimalValue = new List<string>();

        while (decimalNumber > 0)
        {
            remainder = (int)(decimalNumber % 16);
            decimalNumber = decimalNumber / 16;

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

