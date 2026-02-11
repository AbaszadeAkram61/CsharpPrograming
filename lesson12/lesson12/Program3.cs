using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lesson12
{
    internal class Program3
    {
        const string LogsFile = @"D:\\Logs\\logs.txt";

        static void Main()
        {
            int number;
            bool validInput = false;

            while (!validInput)
            {
                try
                {
                    Console.Write("Zəhmət olmasa bir ədəd daxil edin: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    validInput = true;

                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Daxil edilən cüt ədəd: " + number);
                    }
                    else
                    {
                        Console.WriteLine("Daxil edilən ədəd təkdir.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Daxil edilən dəyər düzgün ədəd deyil! Yenidən cəhd edin.");
                }
            }
        }
    }
}
