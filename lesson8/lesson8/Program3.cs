using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace lesson8.three
{
    internal class Program3
    {
        public static void Main3()
        {
            //    Create a new C # project with three classes plus another class to test the logic in your code. The main classes of the program are the following classes:

            //    Person
            //    Student
            //    Professor
            //    The Student and Teacher classes inherit from the Person class.

            //    The Student class will include a public Study() method that will write I'm studying on the screen.

            //     The Person class must have two public methods Greet() and SetAge(int age) that will assign the age of the person.

            //    The Teacher class will include a public Explain() method that will write I'm explaining on the screen.

            //    Also create a public method ShowAge() in the Student class that writes My age is: x years old on the screen.

            //    You must create another test class called StudentProfessorTest with a Main method to do the following:

            //    Create a new Person and make him say hello
            //    Create a new Student, set an age, say hello, and display her age on the screen.
            //    Create a new Teacher, set an age, say hello and start the explanation.

            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.age = 19;
            student.Greet();
            student.ShowAge();

            Professor professor = new Professor();
            professor.age = 50;
            professor.Greet();
            professor.Explain();

        }
    }
    public class Person
    {
        public int age;
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int n)
        {
            age = n;
        }
    }

    public class Student:Person 
    { 
        public void Study()
        {
            Console.WriteLine("I am studying");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is:{age} years");
        }
    }

    public class Professor:Person
    {
        public void Explain()
        {
            Console.WriteLine("I am explaining");
        }
    }



}
