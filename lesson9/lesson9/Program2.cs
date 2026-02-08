using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace lesson9
{
    internal class Program2
    {
        public static void Main()
        {
            //Create a SchoolPerson class that has SchoolName, Name, Surname, Age and DateOfBirth, CurrentClass properties.Also this class will have a general Greet method, which will show us "Hello {Name Surname}".

            //Create a class "Student" and another class "Teacher", both descendants of "SchoolPerson" class. "SchoolPerson" will have a method calles "GoToClasses" and when calling this method it will show us "Inside Base GoToClasses method"

            //The class "Student" will also have a public method "GoToClasses", which will write on screen "I’m {name surname}, I am student and I'm going to class."

            //The class "Teacher" will have a public method "Explain", which will show on screen "Explanation begin on subject {subject}". Also, it will have a private attribute "subject", a string which indicates his/her speciality.Also "Teacher" will have a public method "GoToClasses", which will write on screen "I’m {name surname}, I am a teacher."

            //The class SchoolPerson must have a functionality to set of their age(eg, 20 years old). Note: Age cannot be less than 6 and more than 50. If we try to assign invalid number exception should be thrown.

            //The student will have a public method "ShowAge" which will write on the screen "My age is: 20 years old" (or the corresponding number).

            //You must create another test class called "StudentAndTeacherTest" that will contain "Main" and:
            //Create a SchoolPerson and make it say hello
            //Create a student, set his age to 21, tell him to Greet, display his age and make him to go classes
            //Create a teacher, set age to 30 years old, ask him to say hello, then go to classes and then explain.

            SchoolPerson schoolPerson = new SchoolPerson("Akram","Abaszade",25);
            schoolPerson.Greet();
            Console.WriteLine(schoolPerson.Age = 25);
            schoolPerson.GoToClasses();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            

            Teacher teacher = new Teacher("Arif","Talibov",30);
            teacher.Greet();
            teacher.GoToClasses();
            teacher.Explain();


        }
    }
}
public class SchoolPerson
{
    public string SchoolName {  get; set; }
    public string Name { get; set; }
    public string Surname {  get; set; }

    public SchoolPerson(
        string Name,
        string Surname,
        byte Age
  
       )
    {
        
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
    }
    private byte age;
    public byte Age { 
        get
        {
            return age;
        }
        set
        {
            if (value > 6 && value < 50)
            {
                age = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Age must be between 7 and 49.");
            }

        }
    }
    public DateTime DateOfBirth {  get; set; }
    public string CurrentClass {  get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hello {Name} {Surname}");
    }
    public virtual void GoToClasses()
    {
        Console.WriteLine("Inside Base GoToClasses ");
    }
}
public class Student:SchoolPerson
{
    public Student(
        string Name, 
        string Surname,
        byte Age
      ) : base( Name, Surname, Age)
    {

    }

    public override void GoToClasses()
    {
        Console.WriteLine($"I'm {Name} {Surname} student and I'm going to class");
    }
    public void ShowAge ()
    {
        Console.WriteLine($"My age is{Age}");
    }
}
public class Teacher : SchoolPerson
{
    public Teacher(
        
        string Name,
        string Surname,
        byte Age
       ) : base( Name, Surname, Age)
    {

    }

    private string Subject {  get; set; }

    public void Explain()
    {
        Console.WriteLine($"Explanation begin on {Subject}");
    }
    public override void GoToClasses()
    {
        Console.WriteLine($"I am {Name} {Surname} I am a teacher");
    }
}
