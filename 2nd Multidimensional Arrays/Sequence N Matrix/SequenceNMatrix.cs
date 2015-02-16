using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
Example:

matrix	                result		    matrix	        result
ha	fifi ho	hi                          s	qq	s
fo	ha	 hi	xx         ha, ha, ha       pp	pp	s       s, s, s
xxx	ho	 ha	xx                          pp	qq	s
 
 */

class SequenceNMatrix
{
    static void Main()
    {
        Console.WriteLine("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("M = ");
        int m = int.Parse(Console.ReadLine());

        string[,] array = new string[n, m];
        // Read data from console
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("Array[{0},{1}] = ", row, col);
                array[row, col] = Console.ReadLine();
            }
        }
        int numMaxElements = 0;
        int numCurrElements = 0;
        string maxStr = "";

        // Iterate through the matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                // Find horizontal sequences
                numCurrElements = 0;
                for (int currentCol = col; currentCol < m - 1; currentCol++)
                {
                    if (array[row, currentCol + 1] == array[row, currentCol])
                    {
                        numCurrElements++;
                    }
                    if (numCurrElements > numMaxElements)
                    {
                        numMaxElements = numCurrElements;
                        maxStr = array[row, currentCol];
                    }
                }
                // Find vertical sequences
                numCurrElements = 0;
                for (int currentRow = row; currentRow < n - 1; currentRow++)
                {
                    if (array[currentRow, col] == array[currentRow + 1, col])
                    {
                        numCurrElements++;
                    }

                    if (numCurrElements > numMaxElements)
                    {
                        numMaxElements = numCurrElements;
                        maxStr = array[currentRow, col];
                    }
                }
                // Find diagonal sequences
                numCurrElements = 0;
                for (int currentRow = row, currentCol = col; (currentRow < n - 1) && (currentCol < m - 1); currentRow++, currentCol++)
                {
                    if (array[currentRow, currentCol] == array[currentRow + 1, currentCol + 1])
                    {
                        numCurrElements++;
                    }
                    if (numCurrElements > numMaxElements)
                    {
                        numMaxElements = numCurrElements;
                        maxStr = array[currentRow, currentCol];
                    }
                }
            }
        }
        // Print the result
        Console.WriteLine();
        for (int i = 0; i <= numMaxElements; i++)
        {
            if (i == numMaxElements)
            {
                Console.WriteLine(maxStr);
            }
            else
            {
                Console.Write(maxStr + ", ");
            }
        }
    }
}