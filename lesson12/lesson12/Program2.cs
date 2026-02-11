using System;
using System.Collections.Generic;
using System.Text;

namespace lesson12
{
    internal class Program2
    {
        const string LogsFile = @"D:\\Logs\logs.txt";
        //The static methods in the static class System.Convert are able to convert values of one type to values of another type.

        //Consult the documentation of** System.Convert.ToDouble**. There are several overloads of this method.Which exceptions can occur by converting a string to a double?

        //Write a program which triggers these exceptions.

        //Finally, supply handlers of the exceptions.The handlers should report the problem on standard output, rethrow the exception, and then continue.


        public static void Main3()
        {
            string text = "Akram";
            try
            {
                double ChangeText = Convert.ToDouble(text);
            }
            catch (Exception exc)
            {
                File.AppendAllText(LogsFile, DateTime.Now + "\n" + exc.ToString() + "\n\n");
                

            }
            finally
            {
                Console.WriteLine("Program ended");
            }
            
        }
        

    }
}
