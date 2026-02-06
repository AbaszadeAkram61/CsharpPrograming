using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lesson7
{
    internal class Program2
    {
        private static void Main2()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Program2.plusMinus(arr);
        }

       // Given an array of integers, calculate the ratios of its elements that are, , and . Print the decimal value of each fraction on a new line with 6 places after the decimal.

       // Note: This challenge introduces precision problems.The test cases are scaled to six decimal places, though answers with absolute error of up to are acceptable.

       // Example

       // There are elements: two positive, two negative and one zero.Their ratios are, and.Results are printed as:

       // 0.400000
       // 0.400000
       // 0.200000
       // Function Description

       // Complete the  function with the following parameter(s):

       //: an array of integers
       // Print
       // Print the ratios of positive, negative and zero values in the array. Each value should be printed on a separate line with  digits after the decimal. The function should not return a value.

       // Input Format

       // The first line contains an integer, , the size of the array.
       // The second line contains  space-separated integers that describe .

       // Constraints



       //Sample Input

       //STDIN           Function
       // -----           --------
       // 6               arr[] size n = 6
       // - 4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]
       // Sample Output

       // 0.500000
       // 0.333333
       // 0.166667

        public static void plusMinus(List<int> arr)
        {
            int ArrCount = 0;
            decimal PlusArrCount = 0;
            decimal MinusArrCount = 0;
            decimal ZeroArrCount = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                ArrCount++;
                if (arr[i] > 0)
                {
                    PlusArrCount++;
                }
                else if (arr[i] < 0)
                {
                    MinusArrCount++;
                }
                else if (arr[i] == 0)
                {
                    ZeroArrCount++;
                }
            }
            decimal result1 = PlusArrCount / ArrCount;
            decimal result2 = MinusArrCount / ArrCount;
            decimal result3 = ZeroArrCount / ArrCount;
            Console.WriteLine($"{result1}");
            Console.WriteLine($"{result2}");
            Console.WriteLine($"{result3}");
        }
    }
}
