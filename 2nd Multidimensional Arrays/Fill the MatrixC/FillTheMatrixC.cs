using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:

7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10 
 
*/

class FillTheMatrixC
{
    static void Main()
    {
        Console.WriteLine("Please enter the length and the width:");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int number = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            int row = i;
            int col = 0;
            do
            {
                matrix[row, col] = number;
                row++;
                col++;
                number++;
            } while (row < n);
        }
        for (int i = 0; i < n; i++)
        {
            int row = 0;
            int col = i;
            do
            {
                matrix[row, col] = number;
                row++;
                col++;
                number++;
            } while (col < n);
        }
        PrintMatrix(n, matrix);
    }

    private static void PrintMatrix(int n, int[,] matrix)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
