using System.ComponentModel;

internal class Program
{

    private static void Main()
    {
        //Get 2 int number input from user and calculate the exact input1 / input2.Example: 16, 5.Result should be 3.2 not 3.
        Console.WriteLine("Please enter int number1");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter int number2");
        int number2 = int.Parse(Console.ReadLine());

        double result =(double) number1 / number2;

        Console.WriteLine($"Result is {result} ");
    }


    private static void Main2()
    {
        //Write a C# program which takes 2 string input from user and return if second string is in first string. Example. 1st input: Azərbaycan, 2nd input: can, Result should be true because can is in Azərbaycan
        Console.WriteLine("Please enter first string");
        string text1 = Console.ReadLine();

        Console.WriteLine("Please enter second string");
        string text2 = Console.ReadLine();

        var result= text1.Contains(text2);

        Console.WriteLine(result);
    }
    private static void Main1(string[] args)
    {
        //Write a C# program that takes two numbers as input and returns true or false when both numbers are even or odd

        Console.WriteLine("Please enter number1");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter number2");
        int number2 = int.Parse(Console.ReadLine());

        bool result = number1 % 2 == 0 && number2 % 2 == 0;

        Console.WriteLine(result);
    }
}