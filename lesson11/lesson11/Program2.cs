using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace lesson11
{
    internal class Program2
    {
        public static void Main2()
        {
            //Write a program in C# Sharp to create and read the last line of a file.
            //Test Data:
            //            Input number of lines to write in the file :3
            //Input 3 strings below :
            //Input line 1 : line1
            //Input line 2 : line2
            //Input line 3 : line3

            //Expected Output:

            //The content of the last line of the file mytest.txt is: line3

            string filePath = "mytest.txt";

            Console.Write("Input number of lines to write in the file: ");
            int n = int.Parse(Console.ReadLine());

            // Faylı yaratmaq və sətirləri yazmaq
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"Input line {i}: ");
                    string line = Console.ReadLine();
                    writer.WriteLine(line);
                }
            }

            // Fayldan son sətri oxumaq
            string lastLine = null;
            string[] allLines = File.ReadAllLines(filePath); // Bütün sətirləri oxuyur
            if (allLines.Length > 0)
            {
                lastLine = allLines[allLines.Length - 1];
            }

            Console.WriteLine($"\nThe content of the last line of the file {filePath} is: {lastLine}");
        }


    }

    }

