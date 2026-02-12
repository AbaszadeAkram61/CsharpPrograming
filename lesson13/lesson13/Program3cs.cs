using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace lesson13
{
    internal class Program3cs
    {
        public static void Main3()
        {
            //Please add a new value, the key of which is your name, and the value of which is your age. Do this using the Add method.

            //Next, add another value to the dictionary using the index notation.This time, use a different name and a different age.

            //Lastly, read the first item you added to the dictionary, and write it to the console using Console.WriteLine.
            Dictionary<string, int> people = new Dictionary<string, int>();
            people.Add("Akram", 25);
            people.Add("Kamran", 20);


            foreach (var item in people)
            {
                Console.WriteLine($"The first person on the list of peaople is:" + item);
                break;
            }
        }
    }
}
