using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

/*
Integer calculations

Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
 */

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("Enter the elements of the array on one line separated by ',':");
        
        int[] numbers = //new int[] { 2, 3, 6, 16, 2, 45, 6, 4, 8, 9 };
                         Console.ReadLine()
                        .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();

        int numberOfElements = numbers.Length;
               
        Console.WriteLine("The min value is: {0}", ReturnMinValueInGivenArray(numbers, numberOfElements));
        Console.WriteLine("The max value is: {0}", ReturnMaxValueInGivenArray(numbers, numberOfElements));
        Console.WriteLine("The average value is: {0}", ReturnAverageValueInGivenArray(numbers, numberOfElements));
        Console.WriteLine("The product is: {0}", ReturnProductOfGivenArrayElements(numbers, numberOfElements));
    }

    private static BigInteger ReturnProductOfGivenArrayElements(int[] numbers, int numberOfElements)
    {
        BigInteger product = 1;
        for (int i = 0; i < numberOfElements; i++)
        {
            product *= numbers[i];
        }
        return product;
    }

    private static double ReturnAverageValueInGivenArray(int[] numbers, int numberOfElements)
    {
        int sum = 0;
        double average = 0;
        for (int i = 0; i < numberOfElements; i++)
        {
            sum += numbers[i];
        }
        average = sum / (double)numberOfElements;
        return average;
    }

    private static int ReturnMaxValueInGivenArray(int[] numbers, int numberOfElements)
    {
        int maxValue = int.MinValue;
        for (int i = 0; i < numberOfElements; i++)
        {
            if (numbers[i] > maxValue)
            {
                maxValue = numbers[i];
            }
        }
        return maxValue;
    }

    private static int ReturnMinValueInGivenArray(int[] numbers, int numberOfElements)
    {
        int minValue = int.MaxValue;
        for (int i = 0; i < numberOfElements; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
            }
        }
        return minValue;
    }
}
