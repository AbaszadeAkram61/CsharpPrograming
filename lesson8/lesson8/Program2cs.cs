using System;
using System.Collections.Generic;
using System.Text;

namespace lesson8
{
    internal class Program2cs
    {
        public static void Main2()
        {
            Person[] persons = new Person[3];

            for (int i = 0; i < persons.Length; i++)
            {
                Console.Write("Please enter names:");
                persons[i] = new Person(Console.ReadLine());

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

        public Person(string name)
        {
            Name = name;
        }


        ~Person()
        {
            Name = string.Empty;
        }

        public string ToString()
        {
            return "Hello! My name is " + Name;
        }
    }
  

}
