using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{

  
    public static void Main8()
    {
        //Write a C# program to find prime numbers up to users entered value.
        //Exmpl: input - 100, Result: 2, 3, 5, 7, 11, 13... 89, 97

        Console.Write("Please enter value");
        int Input = int.Parse(Console.ReadLine());

        for (int i = 2; i <= Input; i++) 
        {
            bool sade = true; 

            for (int j = 2; j <= Math.Sqrt(i); j++) 
            {
                if (i % j == 0) 
                {
                    sade = false; 
                    break;       
                }
            }

            if (sade) 
            {
                Console.Write(i + " "); 
            }
        }

    }

    public static void Main7()
    {
        //Write a program in C# to display the sum of the series [ 9 + 99 + 999 + 9999 ...]. Test Data :
        //Input the number or terms :5
        //Expected Output :
        //9 99 999 9999 99999
        //The sum of the series = 111105

        Console.Write("Rəqəm və ya şərtləri daxil edin: ");
        int n = int.Parse(Console.ReadLine());

        int num = 0;
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            num = num * 10 + 9;  
            Console.Write(num + " ");
            sum += num;
        }

        Console.WriteLine();
        Console.WriteLine("Seriyanın cəmi = " + sum);


    }
    public static void Main6()
    {
        //Write a program in C# to make such a pattern like right angle triangle with number increased by 1. The pattern like :
        //1
        //2 3
        //4 5 6
        //7 8 9 10

        int num = 1;

        for (int i = 1; i <= 4; i++)        
        {
            for (int j = 1; j <= i; j++)   
            {
                Console.Write(num + " ");
                num++; 
            }
            Console.WriteLine(); 
        }
    }


    public static void Main5()
    {
        //    Write a program in C# to display the pattern like right angle triangle using an asterisk. The pattern like :

        //    *
        //    **
        //    ***
        //    ****
        //    *****

        for (int i = 1; i <= 5; i++)     
        {
            for (int j = 1; j <= i; j++) 
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
        }


    }



    private static void Main4()
    {
        //Write a program in C# to display the multiplication table vertically from 1 to n.
        //Test Data:
        //Input upto the table number starting from 1 : 8
        //Expected Output:
        //Multiplication table from 1 to 8
        //1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8...
        //1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80

        Console.Write("Input n:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <=10 ; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write($"{j}x{i}={j * i},");
            }
            Console.WriteLine();
        }


    }


    private static void Main3()
    {
        //Write a program in C# to read 5 numbers from keyboard and find their sum and average.
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"numbers[{i}]=");
            numbers[i] = int.Parse(Console.ReadLine());
            
        }

       int sumNumbers= SumNumbers(numbers);
        AverageNumbers(sumNumbers);
    }

    static int  SumNumbers(int[] numbers)
    {
        int sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }
        Console.WriteLine($"The numbers sum is {sum}");
        return sum;
    }

    static void AverageNumbers(int sumNumbers)
    {
        int average = sumNumbers / 5;
        Console.WriteLine($"5 numbers find average is {average}");
    }

    private static void Main2()
    {
        //Write a C# program to find the sum of first 20 odd natural numbers.
        int sum = 0;
        for (int i = 1; i <= 20; i++)
        {
            if (i%2!=0)
            {
                sum += i;
            }

        }
        Console.WriteLine($"The sum of first 20 odd natural is: {sum} ");
    }

    private static void Main1(string[] args)
    {
        // Write a program in C# to display the first 10 natural numbers
        for (int i = 1; i <=10; i++)
        {
            Console.WriteLine(i);
        }
    }
}