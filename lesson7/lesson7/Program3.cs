using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lesson7
{
    internal class Program3
    {
        private static void Main3()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = Program3.birthdayCakeCandles(candles);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }


        //You are in charge of the cake for a child's birthday. It will have one candle for each year of their total age. They will only be able to blow out the tallest of the candles. Your task is to count how many candles are the tallest.

        //Example


        //The tallest candles are 4 units high.There are 2 candles with this height, so the function should return 2.

        //Function Description

        //Complete the function with the following parameter(s):

        //: the candle heights
        //Returns

        //: the number of candles that are tallest
        //Input Format

        //The first line contains a single integer, , the size of.
        //The second line contains  space-separated integers, where each integer describes the height of.

        //Constraints

        //Sample Input 0

        //4
        //3 2 1 3
        //Sample Output 0

        //2
        //Explanation 0

        //Candle heights are.The tallest candles are  units, and there are of them.




        public static int birthdayCakeCandles(List<int> candles)
        {
            int BigCandlesCount = 0;
            int MaxCandles = candles.Max();
            for (int i = 0; i < candles.Count; i++)
            {
                if (MaxCandles == candles[i])
                {
                    BigCandlesCount++;
                }
            }
            return BigCandlesCount;
        }
    }
}
