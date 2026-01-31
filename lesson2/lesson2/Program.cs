using System;
using System.ComponentModel;

internal class Program
{

    private static void Main()
    {
        // Write a C# program that takes the radius of a circle as input and calculate the perimeter and area of the circle and print it in console
        Console.WriteLine("Please enter the radius of a circle ");
        int r = int.Parse(Console.ReadLine());

        double perimetr = 2 * Math.PI * r;

        double area = Math.PI * r * r;

        Console.WriteLine("Perimetr:" + perimetr);
        Console.WriteLine("Area:" + area);
    }



    private static void Main2()
    {
        // Write a C# program that takes 2 inputs form user respectively name and surname, and then print it as "NAME SURNAME" (both uppercase)
        //in console

        Console.WriteLine("Please enter name:");
        string name = Console.ReadLine();

        Console.WriteLine("Please enter surname:");
        string surname = Console.ReadLine();

        Console.WriteLine(name.ToUpper() +" "+ surname.ToUpper());
    }


    private static void Main1(string[] args)
    {
        //Write a C# program that takes three letters as input and display them in reverse order.

        Console.WriteLine("Plesase enter first letter");
        char var1 = char.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second letter");
        char var2 = char.Parse(Console.ReadLine());

        Console.WriteLine("Please enter three letter");
        char var3 = char.Parse(Console.ReadLine());

        Console.WriteLine(var3.ToString() + var2.ToString() + var1.ToString());

    }
}