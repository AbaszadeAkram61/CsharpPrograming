using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace lesson13
{
    internal class Program2
    {
        public static void Main2()
        {
            //Please remove the item with the key 'Han' from the dictionary.
            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                { "Luke", true },
                { "Han", false },
                { "Chewbacca", false }
            };

            foreach (var item in characters)
            {
                if (characters.ContainsKey("Han"))
                {
                    characters.Remove("Han");
                }

                
                
            }

            foreach (var item in characters)
            {
                Console.WriteLine($"Item key is {item.Key},item is value is {item.Value}");
            }

        }
    }
}
