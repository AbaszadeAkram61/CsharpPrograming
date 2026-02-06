using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{

    //Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.Then print the respective minimum and maximum values as a single line of two space-separated long integers.

    //Example

    //The minimum sum is  and the maximum sum is . The function prints

    //16 24
    //Function Description

    //Complete the  function with the following parameter(s):

    //: an array of integers
    //Print

    //Print two space-separated integers on one line: the minimum sum and the maximum sum of  of elements.No value should be returned.

    //Note For some languages, like C, C++, and Java, the sums may require that you use a long integer due to their size.

    //Input Format

    //A single line of five space-separated integers.

    //Constraints


    //Sample Input

    //1 2 3 4 5
    //Sample Output

    //10 14


    private static void Main1(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Program.miniMaxSum(arr);
    }

    public static void miniMaxSum(List<int> arr)
    {
        long sum = 0;
        int arrmin = arr.Min();
        int arrmax = arr.Max();
        for (int i = 0; i < arr.Count; i++)
        {
            sum += arr[i];

        }
        Console.WriteLine($"{sum - arrmax} {sum - arrmin}");

    }
}