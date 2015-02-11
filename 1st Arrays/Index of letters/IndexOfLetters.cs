using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
 */

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 65; i <= 90; i++)
        {
            alphabet[i - 65] = (char)i;
        }
        Console.WriteLine("Please enter only capital letters:");
        string input = Console.ReadLine();
        char[] text = input.ToCharArray();

        Console.WriteLine("The indices are:");
        for (int i = 0; i < text.Length; i++)
        {
            char value = text[i];
            int foundIndex = Array.IndexOf(alphabet, value);
            Console.Write("{0} ", foundIndex);
        }
    }
}
