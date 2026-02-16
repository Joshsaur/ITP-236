using System;
using System.Collections.Generic;

namespace EID
{
    /// <summary>
    /// Demonstrates Extensions, Interfaces, and Delegates.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Delegate that takes a string and returns a string.
        /// </summary>
        public delegate string PersonOp(string input);

        static void Main(string[] args)
        {
            // Delegates
            PersonOp toLower = s => s.ToLower();
            PersonOp toProper = s => s.ProperName();

            // Create objects
            IPerson student = new Student
            {
                FirstName = "rIVEN",
                LastName = "sTORM",
                Age = 20,
                Email = "riven@student.edu",
                Major = "Computer Science"
            };

            IPerson teacher = new Teacher
            {
                FirstName = "aLEX",
                LastName = "mERCER",
                Age = 40,
                Email = "alex@school.edu",
                Subject = "Math"
            };

            IPerson admin = new Administrator
            {
                FirstName = "jORDAN",
                LastName = "bLAKE",
                Age = 35,
                Email = "jordan@school.edu",
                Department = "Admissions"
            };

            List<IPerson> people = new List<IPerson>
            {
                student,
                teacher,
                admin
            };

            foreach (IPerson person in people)
            {
                person.Display();

                string fullName = person.FirstName + " " + person.LastName;

                Console.WriteLine("Lowercase: " + toLower(fullName));
                Console.WriteLine("Proper Case: " + toProper(fullName));
                Console.WriteLine("--------------------------------");
            }

            Console.ReadKey();
        }
    }
}