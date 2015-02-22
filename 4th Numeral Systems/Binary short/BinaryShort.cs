using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Binary short

Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
 */

class BinaryShort
{
    static void Main()
    {
        Console.WriteLine("Please enter a random number of type short:");
        short decimalNumber = short.Parse(Console.ReadLine());

        List<int> binary = new List<int>();
        if (decimalNumber >= 0)
        {
            for (int i = 0; i < 16; i++)
            {
                int remainder = decimalNumber % 2;
                decimalNumber = (short)(decimalNumber / 2);
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
        else
        {
            decimalNumber = (short)((decimalNumber + 1) * (-1));
            for (int i = 0; i < 16; i++)
            {
                int remainder = decimalNumber % 2;
                remainder = remainder ^ 1;
                decimalNumber = (short)(decimalNumber / 2);
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
}
