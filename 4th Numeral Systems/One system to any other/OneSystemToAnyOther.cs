using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
One system to any other

Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
 */

class OneSystemToAnyOther
{
    
    static void Main()
    {
        Console.WriteLine("Please enter the S-based system (2 <= S <= 16):");
        int s = int.Parse(Console.ReadLine());
       
        Console.WriteLine("Please enter the D-based system (2 <= D <= 16):");
        int d = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter the number:");
        char[] input = Console.ReadLine().ToUpper().ToCharArray();
        
        BigInteger decimalNumber = 0;
        int position = 0;
        int digit = 0;
        // converts from any to decimal
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (Char.IsLetter(input[i]))
            {
                digit = input[i] - 'A' + 10;
            }
            else
            {
                digit = input[i] - '0';
            }
            BigInteger power = (BigInteger)(double)Math.Pow(s, position);
            decimalNumber += digit * power;
            position++;
        }
        StringBuilder result = new StringBuilder();
        char letter = '\0';
        // converts from decimal to any
        while (decimalNumber > 0)
        {
            int remainder = (int)(decimalNumber % d);
            if (remainder > 10)
            {
                letter = (char)(remainder + 'A' - 10);
            }   
            else
            {
                letter = (char)(remainder + '0');
            }   
            decimalNumber = decimalNumber / d;
            result.Insert(0, letter);
        }
        Console.WriteLine("Its D-based system representation is:");
        Console.WriteLine(result);
    }
}

