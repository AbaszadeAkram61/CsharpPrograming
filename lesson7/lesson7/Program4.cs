using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lesson7
{
    internal class Program4
    {
        private static void Main()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Program4.timeConversion(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }


        //Given a time in -hour AM/PM format, convert it to military(24-hour) time.

        //Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
        //- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

        //Example


        //Return '12:01:00'.


        //Return '00:01:00'.

        //Function Description

        //Complete the  function with the following parameter(s):

        //: a time in hour format
        //Returns

        //: the time in hour format
        //Input Format

        //A single string that represents a time in -hour clock format (i.e.:  or ).

        //Constraints

        //All input times are valid
        //Sample Input 0

        //07:05:45PM
        //Sample Output 0

        //19:05:45




        public static string timeConversion(string s)
        {
            string period = s.Substring(s.Length - 2);


            int hour = int.Parse(s.Substring(0, 2));


            string rest = s.Substring(2, 6);

            if (period == "AM")
            {
                if (hour == 12)
                    hour = 0;
            }
            else
            {
                if (hour != 12)
                    hour += 12;
            }


            return hour.ToString("D2") + rest;
        }

    }
}

