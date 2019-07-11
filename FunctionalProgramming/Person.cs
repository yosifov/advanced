// <copyright file="Person.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;

    /// <summary>
    /// Person Class for storing different persons with Name and Age. Used for Filter by Age Task
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Store Person name
        /// </summary>
        private string name;

        /// <summary>
        /// Store Person age
        /// </summary>
        private int age;

        /// <summary>
        /// Initializes a new instance of the Person class. Sets Person name and age.
        /// </summary>
        /// <param name="name">Person name</param>
        /// <param name="age">Person age</param>
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        /// <summary>
        /// Gets or sets person name
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 1 || value.Length > 50)
                {
                    throw new ArgumentException("Person name must be between 2 and 50 symbols.");
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets person age
        /// </summary>
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Person age must be between 1 and 100 years");
                }

                this.age = value;
            }
        }

        /// <summary>
        /// Prints Person Name and Age on the console
        /// </summary>
        /// <param name="name">Person name</param>
        /// <param name="age">Person age</param>
        public void GetPersonInformation(string name, int age)
        {
            Console.WriteLine($"{name} - {age}");
        }

        /// <summary>
        /// Prints Person Name on the console
        /// </summary>
        /// <param name="name">Person name</param>
        public void GetPersonInformation(string name)
        {
            Console.WriteLine(name);
        }

        /// <summary>
        /// Prints Person Age on the console
        /// </summary>
        /// <param name="age">Person age</param>
        public void GetPersonInformation(int age)
        {
            Console.WriteLine(age);
        }
    }
}