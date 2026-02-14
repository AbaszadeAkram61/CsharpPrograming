using lesson14;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

internal class Program
{
    private static void Main1(string[] args)
    {
        //We have User(Name, Surname, Age, Country) class and list of User objects
        //a) Write a method to generate about 10 user objects and return them as list.
        //b) Find all users that age is greater than 20 and print them as "Name Surname Age Country" format.ex: "Nurlan Valizada 28 Azerbaijan"
        //c) Remove all users that belongs to Turkey and Age is lower than 10
        
        UserManager userManager = new UserManager();
        var Users= userManager.GetUsers();
        Console.WriteLine();
        var FilteredUsers= Users.Where(u => u.Age > 20).ToList();
        FilteredUsers.PrintUsers();
        Console.WriteLine();
        
        var FilteredUsersAge10AndTurkey = Users.RemoveAll(u => (u.Age < 10) && (u.Counrty == "Turkey"));
        

    }
}
public class User
{
    public User(string name,string surname,byte age,string country)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Counrty = country;
    }
    public string Name { get; set; }
    public string Surname { get; set; } 
    public byte Age { get; set; }
    public string Counrty {  get; set; }

}