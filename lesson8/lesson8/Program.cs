internal class Program
{

    private static void Main1(string[] args)
    {
      

        //Create a C# program that requests three names of people from the user and stores them in an array of objects of type Person. To do this, first create a Person class that has a Name property of type string and override the ToString() method.

        //End the program by reading people and executing the ToString() method on the screen.

        Person[] persons = new Person[3];

        for (int i = 0; i < persons.Length; i++)
        {
            Console.Write("Please enter names:");
            persons[i] = new Person();
            persons[i].Name = Console.ReadLine();


        }
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(persons[i].ToString());
        }

    }
}
public class Person
{ 
    public string Name { get; set; }

    public override string ToString()
    {
        return "Hello! My name is " + Name;
    }
}
