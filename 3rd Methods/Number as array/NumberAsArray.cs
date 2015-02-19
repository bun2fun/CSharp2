using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Number as array

Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
 */

class NumberAsArray
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        SumAndPrintPositiveIntegersGivenAsArray(firstInput, secondInput);
    }

    private static void SumAndPrintPositiveIntegersGivenAsArray(string firstInput, string secondInput)
    {
        char[] largerNumber = new char[10000];
        char[] smallerNumber = new char[10000];

        if (firstInput.Length > secondInput.Length)
        {
            largerNumber = firstInput.ToCharArray();
            smallerNumber = secondInput.ToCharArray();
        }
        else
        {
            smallerNumber = firstInput.ToCharArray();
            largerNumber = secondInput.ToCharArray();
        }
        Array.Reverse(smallerNumber);
        Array.Reverse(largerNumber);

        int adjustedLength = 0;
        int[] result = new int[10001];
        int carrier = 0;
        int remainder = 0;
        int value = 0;
        int difference = 0;

        adjustedLength = smallerNumber.Length;
        difference = largerNumber.Length - smallerNumber.Length;

        // adds the calculations for the common length of both arrays
        for (int i = 0; i < adjustedLength; i++)
        {
            value += ((largerNumber[i] - 48) + (smallerNumber[i] - 48));
            carrier = value / 10;
            remainder = value % 10;
            result[i] += remainder;
            value = 0;
            value += carrier;
        }
        // if one array has larger length then it adds the calculations for the rest of its length
        for (int i = 0; i < difference; i++)
        {
            result[adjustedLength + i] += value;
            result[adjustedLength + i] += (largerNumber[adjustedLength + i] - 48);
            value = result[adjustedLength + i] / 10;
            result[adjustedLength + i] = result[adjustedLength + i] % 10;
        }
        // in case the last calculation gives number > 9 then the two digits are placed on separate positions
        if (value != 0)
        {
            result[difference + adjustedLength] += value;
        }
        // print
        for (int i = difference + adjustedLength; i > 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}