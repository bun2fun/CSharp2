using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
Binary to decimal

Write a program to convert binary numbers to their decimal representation.
 */

class BinaryToDecimal
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
        Console.WriteLine("Its decimal representation is:");
        Console.WriteLine(decimalNumber);
    }
}

