using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
 Maximal sum

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
 
 */

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Please enter the number of rows in the matrix:");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of columns in the matrix::");
        int M = int.Parse(Console.ReadLine());

        if (N < 3 || M < 3)
        {
            Console.WriteLine("The size of the matrix has to be at least 3 x 3");
        }
        else
        {
            int bestMax = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            int[,] matrix = new int[N, M];
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M; col++)
                {
                    Console.Write("matrix[{0}, {1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            //int[,] matrix = new int[5, 5]   
            //{
            //        { 1, 0, 0, 6, 0 },
            //        { 0, 0, 0, 1, 1 },
            //        { 2, 0, 0, 9, 1 },
            //        { 0, 1, 15, 3, 0 },
            //        { -1, 2, 0, 0, 15 }
            //};

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    if (row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1)
                    {
                        int maxSub = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                                   + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                                   + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                        if (maxSub > bestMax)
                        {
                            bestMax = maxSub;
                            bestRow = row;
                            bestCol = col;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("The max sub array is:");
            for (int row = bestRow; row < bestRow + 3; row++)
            {
                for (int col = bestCol; col < bestCol + 3; col++)
                {
                    Console.Write("{0, 4} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}


