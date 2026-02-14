using System;
using System.Collections.Generic;
using System.Text;

namespace lesson14
{
    public static class ExtensionUser
    {
        public static void PrintUsers(this List<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name},{user.Surname},{user.Age},{user.Counrty}");
            }
        }
    }
}
