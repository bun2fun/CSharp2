using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeNumbers
{
    static void Main()
    {
        bool[] myArray = new bool[10000000];
        //initially all numbers are set as prime
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = true;
        }
        for (int i = 2; i < Math.Sqrt(myArray.Length); i++)
        {
            if (myArray[i])
            {
                //when a multiple of i is found, it is crossed out because multiples (i*i) are composite numbers 
                for (int j = i*i; j < myArray.Length; j=j+i)
                {
                    myArray[j] = false;
                }
            }
        }
        //printing only the prime numbers
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}