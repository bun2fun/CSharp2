using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
Example:

input	output
Peter	Hello, Peter!
 */

class SayHello
{
    static void Main()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();

        PrintGreetingAndName(name);
    }

    private static void PrintGreetingAndName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}