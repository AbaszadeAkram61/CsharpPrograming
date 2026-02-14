using System;
using System.Collections.Generic;
using System.Text;

namespace lesson14
{
    public class UserManager
    {
        public List<User> Users { get; set; }

        public List<User> GetUsers()
        {
            return new List<User> {
                new User("Akram","Abaszade",25,"Masalli"),
                new User("Aziz", "Abaszade", 23, "Baki"),
                new User("Samir", "Mehtiyev", 5, "Tovuz"),
                new User("Aygun", "Haciyeva", 18, "Gence"),
                new User("Rauf", "Memmedli", 28, "Sumgayit"),
                new User("Lale", "Ferecova", 9, "Turkiye"),
                new User("Adil", "Memmedov", 17, "Rusiya"),
                new User("Arife", "Humbetova", 7, "Turkiye"),
                new User("Lamiye", "Mehtiyeva", 28, "Masalli"),
                new User("Akif", "Abaszade", 25, "Masalli")

            };

           
        }

    }
}
