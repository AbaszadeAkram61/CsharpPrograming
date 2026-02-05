using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

internal class Program
{

    private static void Main()
    {
        //TwoChangeIntElemet();
        //FibonacciSeriesFindFiveNumber();
        //SumCalcualteNumbers();
        TextFindSpace();
    }


    //Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string. Test Data : Please input a
    //string : This is a test string. Expected Output : "This is a test string." contains 4 spaces
    private static void TextFindSpace()
    {
        Console.Write("Please input string :");
        string text = Console.ReadLine();

        int spaceCount = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i]==' ')
            {
                spaceCount++;
            }
        }


        Console.WriteLine($"\"{text}\" contains {spaceCount} spaces");
    }

    


    //Write a program in C# to create a function to calculate the sum of the individual digits of a given number. Test Data : Enter a number: 123
    //Expected Output : The sum of the digits of the number 1234 is : 10

    private static void SumCalcualteNumbers()
    {
        Console.Write("Please Enter m:");
        int m = int.Parse(Console.ReadLine());
        int sum = 0;

        while (m != 0)
        {
            sum += m % 10;
            m /= 10;
        }

        Console.WriteLine($"The sum of the individual digits is {sum}");

    }



    //Write a program in C# to create a function to display the n number Fibonacci sequence. Test Data : Input number of Fibonacci Series : 5
    //Expected Output : The Fibonacci series of 5 numbers is : 0 1 1 2 3 5 8
    private static void FibonacciSeriesFindFiveNumber()
    {
        Console.Write("Enter Input n:");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c;

      

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }
 
    





    //Write a program in C# to create a function to swap the values of two integer numbers without additional variable. Test Data : Enter a
    //number: 5 Enter another number: 6 Expected Output : Now the 1st number is : 6 , and the 2nd number is : 5
    private static void TwoChangeIntElemet()
    {
        Console.Write("Please Enter integer num1:");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Please Enter integer num2:");
        int num2 = int.Parse(Console.ReadLine());

        num1 = num1 * num2;
        num2 = num1 / num2;
        num1 = num1 / num2;
        Console.WriteLine($"num1:{num1}");
        Console.WriteLine($"num2:{num2}");
    }


    private static void Main123(string[] args)
    {
        //Enter the value between 10 and 100.Initialize int array with random values with length of user entered value.Do following tasks

        //Write a program in C# sort array both descending and ascending order
        //Write a C# program to find the 3rd max element of array.
        //Write a program in C# to find first 4 max elements.

        Console.Write("Enter the value between 10 and 100 n=");
        int n = int.Parse(Console.ReadLine());
        int[] arrays = new int[n];

        Random random = new Random();

        for (int i = 0; i < arrays.Length; i++)
        {
            arrays[i] = random.Next(1, 101);
        }

        //Write a program in C# sort array both descending and ascending order
        Array.Sort(arrays);

        Console.WriteLine("Sorted in ascending order of random number");

        foreach (var item in arrays)
        {
            Console.WriteLine(item);
        }


        Array.Reverse(arrays);

        Console.WriteLine("Sorted in descending order of random number");

        foreach (var item in arrays)
        {
            Console.WriteLine(item);
        }

        //Write a C# program to find the 3rd max element of array.

        Console.WriteLine("\nThe 3rd max element of array is " + arrays[2] + "\n\n");



    }













}