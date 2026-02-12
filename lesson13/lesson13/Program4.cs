using System;
using System.Collections.Generic;
using System.Text;

namespace lesson13
{
    internal class Program4
    {
       
        static void Main()
        {
            List<string> processToKill = new List<string>(3);

            List<string> process = new();

            process.Add("Explorer.exe");
            process.Add("Windows.exe");
            process.Add("Something.exe");


            foreach (var p in process)
            {
                if (p != "Explorer.exe")
                {
                    processToKill.Add(p);
                }
            }

            foreach (var p in processToKill)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine(string.Format("Capacity {0}", processToKill.Capacity));
            Console.WriteLine(string.Format("Count {0}", processToKill.Count));
        }
    }
}
