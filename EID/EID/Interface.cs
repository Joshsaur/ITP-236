using System;

namespace EID
{
    /// <summary>
    /// Defines properties and behavior for a person.
    /// </summary>
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string Email { get; set; }

        void Display();
    }

    /// <summary>
    /// Represents a student.
    /// </summary>
    public class Student : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public string Major { get; set; }

        public void Display()
        {
            Console.WriteLine("Student:");
            Console.WriteLine($"{FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Major: {Major}");
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Represents a teacher.
    /// </summary>
    public class Teacher : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public string Subject { get; set; }

        public void Display()
        {
            Console.WriteLine("Teacher:");
            Console.WriteLine($"{FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Represents an administrator.
    /// </summary>
    public class Administrator : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public string Department { get; set; }

        public void Display()
        {
            Console.WriteLine("Administrator:");
            Console.WriteLine($"{FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine();
        }
    }
}