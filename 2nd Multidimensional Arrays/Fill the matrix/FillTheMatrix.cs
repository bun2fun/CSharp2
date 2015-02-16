using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:

1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16 
 
*/

class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("Please enter the length and the width:");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;

        // Fill in the matrix
        for (int i = 1; i <= n * n; i++)
        {
            matrix[row, col] = i;
            row++;
            if (row >= n)
            {
                col++;
                row = 0;
            }
        }
        // Print
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                Console.Write("{0, 4}", matrix[r, c]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}


