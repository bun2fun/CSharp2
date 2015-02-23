using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Random numbers

Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

class RandomNumbers
{
    static void Main()
    {
        Random number = new Random();

        for (int i = 0; i < 10; i++)
        {
            int result = number.Next(100, 201);
            Console.WriteLine(result);
        }
    }
}

