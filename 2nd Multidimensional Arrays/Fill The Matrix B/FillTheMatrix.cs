using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:

1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13 
 
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
        int number = 1;

        // Fill in the matrix
        while (number <= n * n)
        {
            while (row < n && number <= n * n)
            {
                matrix[row, col] = number;
                row++;
                number++;
            }
            
            if (number <= n * n)
            {
                col++;
                do
                {
                    row--;
                    matrix[row, col] = number;
                    number++;
                } while (row > 0 && number <= n * n);
                col++;
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

//second solution

//        Console.WriteLine("Please enter the length and the width:");
//        int n = int.Parse(Console.ReadLine());

//        int colCounter = 0;
//        int descending = 0;
        
//            for (int i = 1; i <= n; i++)
//            {
//                int row = i - 1;

//                for (int j = i; j <= n * n; )
//                {   
//                    if (i % 2 == 0 && j % 2 == 1 || i % 2 == 1 && j % 2 == 0)
//                    {
//                        colCounter++;
//                        j += (2 * n) - 1;
//                        descending = colCounter * n - row;
//                        Console.Write("{0, 4} ", descending);
//                    }
//                    else
//                    {
//                        Console.Write("{0, 4} ", j);
//                        j++;
//                        colCounter++;
//                    }
//                    if (colCounter == n)
//                    {
//                        colCounter = 0;
//                        break;
//                    }
//                }
//                Console.WriteLine();
//                Console.WriteLine();
//        }
//    }
//}
