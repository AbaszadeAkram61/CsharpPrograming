using System.ComponentModel;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main1(string[] args)
    {
        // Write 2 methods which both accept int n as parameter, iterates from 1 to n and just write "Method1 - i" or "Method2 - i" to console. Then
        // write 2 seperate Threads to run them
        

        Thread Method2Thread = new Thread(() => Method2(50));
        Method2Thread.Start();

        Method1(50);
    }
    public static void Method1(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Method1-{i}");
            Thread.Sleep(50);
        }
       
    }

    public static void Method2(int n) 
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Method2-{i}");
            Thread.Sleep(50);
        }
    }
}