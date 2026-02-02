using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{

    public static void Main()
    {
        //Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.

        //Test Date and Expected Output
        //Enter the first Integer :10
        //Enter the second Integer :2

        //Here are the options :
        //1 - Addition.
        //2 - Substraction.
        //3 - Multiplication.
        //4 - Division.
        //5 - Exit.

        //Input your choice: 3
        //The Multiplication of 10 and 2 is: 20

        Console.Write("Enter number1:");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter number2:");
        int number2 = int.Parse(Console.ReadLine());


        Console.WriteLine("1 - Addition(elave etmek");
        Console.WriteLine("2 - Substraction(cixma)");
        Console.WriteLine("3 - Multiplication(vurma)");
        Console.WriteLine("4 - Division(bolme)");
        Console.WriteLine("5 - Exit");

        Console.Write("Input your choice:");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:Console.WriteLine($"The Addition of {number1} and {number2} is {number1 + number2} ");
                break;
            case 2:Console.WriteLine($"The Substraction of {number1} and {number2} is {number1 - number2}");
                break;
            case 3:Console.WriteLine($"The Multiplication of {number1} and {number2} is {number1 * number2}");
                break;
            case 4:
                Console.WriteLine($"The Divisionof {number1} and {number2} is {number1 / number2}");
                break;
            case 5:
                Console.WriteLine("Exit");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
    public static void Main8()
    {
        // Write a program in C# Sharp to read any day number in integer and display day name in the word. Test Data : 4 Expected Output : Thursday

        Console.Write("Please enter Day:");
        int day = int.Parse(Console.ReadLine());

        DateTime CurrentDate = new DateTime(2026, 02, day);

        Console.WriteLine($"Day name in the word {CurrentDate.DayOfWeek}");
    }


    public static void Main7()
    {
        //Write a C# Sharp program to find the largest of three numbers. Test Data :
        //Input the 1st number :25
        //Input the 2nd number :63
        //Input the 3rd number :10
        //Expected Output :
        //The 2nd Number is the greatest among three

        Console.Write("Input number1:");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Input number2:");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Input number3:");
        int number3 = int.Parse(Console.ReadLine());

        if (number1>number2&&number1>number3)
        {
            Console.WriteLine($"The 2nd Number is the greatest among three {number1}");
        }
        else if (number2>number1&&number2>number3)
        {
            Console.WriteLine($"The 2nd Number is the greatest among three {number2}");
        }
        else if (number3>number2&&number3>number1)
        {
            Console.WriteLine($"The 2nd Number is the greatest among three {number3}");
        }


    }


    public static void Main6()
    {
        //Write a program in C# Sharp to find the last day of a week against a given date. Test Data:
        //Input the Day : 16
        //Input the Month: 06
        //Input the Year: 2016
        //Expected Output :
        //The formatted Date is : 16 / 06 / 2016 The last day of the week for the above date is: 18 / 06 / 2016

        Console.Write("Input day:");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Input month:");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Input year:");
        int year = int.Parse(Console.ReadLine());

        DateTime givenDate = new DateTime(year, month, day);

        int daysToAdd = DayOfWeek.Saturday - givenDate.DayOfWeek;
        DateTime lastDayOfWeek = givenDate.AddDays(daysToAdd);

        Console.WriteLine(
            $"The formatted Date is : {givenDate:dd / MM / yyyy} " +
            $"The last day of the week for the above date is: {lastDayOfWeek:dd / MM / yyyy}"
        );


    }


    public static void Main5()
    {
        //Write a program in C# to get the day of week from last day of the current year against a given date. Test Data:
        //Input the Day : 12
        //Input the Month: 12
        //Input the Year: 2012
        //Expected Output :

        //The formatted Date is : 12 / 12 / 2012
        //The Last day of the year 2012 is : 31 / 12 / 2012


        Console.Write("Input Day:");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Input Month:");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Input Year:");
        int year = int.Parse(Console.ReadLine());

        DateTime givenDate = new DateTime(year, month, day);

        DateTime LastDayOfYear = new DateTime(year, 12, 31);

        DayOfWeek dayOfWeek = LastDayOfYear.DayOfWeek;

        Console.WriteLine($"Day of week from last day of the current year is: {dayOfWeek}");



    }


    public static void Main4()
    {
        //Write a program in C# to check whether the given year, month and day are the current or not. Test Data :
        //Input the Day : 17
        //Input the Month: 09
        //Input the Year: 2016
        //Expected Output :

        Console.Write("Please enter The Day:");
        int day =int.Parse( Console.ReadLine());

        Console.Write("Please enter The Month:");
        int month = int.Parse( Console.ReadLine());

        Console.Write("please enter The Year:");
        int year = int.Parse( Console.ReadLine());

        DateTime NowDate = new DateTime(year, month, day);

        DateTime CurrentDate = DateTime.Now.Date;

        string Result = NowDate == CurrentDate ? "is the current date" : "is not current date";

        Console.WriteLine(Result);
    }


    public static void Main3()
    {
        //Write a C# program to calculate what day of the week is after 40 days from this moment
        DateTime Nowdate = DateTime.Now;

        DateTime AfterDays = Nowdate.AddDays(40);

        Console.WriteLine($"Day of the week is after 40 days {AfterDays.DayOfWeek}");
    }



    public static void Main2()
    {
        //Write a C# that calculates you current life days (how many days past since your birth)

        DateTime NowDate = DateTime.Now;

        DateTime ParseDate = DateTime.Parse("01.01.2001");

        TimeSpan Timerange = NowDate - ParseDate;

        Console.WriteLine($"My current life days is {Timerange.Days} day");
    }


    private static void Main1(string[] args)
    {
        // Write a C# that calculates the day of week (ex: Monday) of your birthday

        DateTime mybirthday = DateTime.Parse("01.01.2001");

        Console.WriteLine($"My birthday is { mybirthday.DayOfWeek}");
    }
}