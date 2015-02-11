using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_sum_in_array
{
    class FindSumInArray
    {
        static void Main()
        {
            //in order to read the input from the console uncomment bellow:

            int s = 11; //int.Parse(Console.ReadLine());

            int[] array = new int[] { 4, 3, 1, 4, 2, 5, 8, 0, 11 };

            //string[] input = Console.ReadLine().Split(',');
            //int[] array = new int[input.Length];
            //for (int i = 0; i < input.Length; i++)
            //{
            //    array[i] = Convert.ToInt32(input[i]);
            //}
           
            int result = 0;
            int counter = 1;
            int lastValue = 0;

            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    result += array[j];
                    counter++;
                    if (result == s)
                    {
                        lastValue = array[j];
                        for (int position = j - counter; position <= j; position++)
                        {
                            if (position == j)
                            {
                                Console.WriteLine("{0}", array[position]);
                            }
                            else
                            {
                                Console.Write("{0}, ", array[position]);   
                            }
                        }
                        counter = 0;
                        result = 0;
                        break;
                    }
                    else if (result > s)
                    {
                        counter = 0;
                        result = 0;
                        break;
                    }
                }
            }
        }
    }
}
