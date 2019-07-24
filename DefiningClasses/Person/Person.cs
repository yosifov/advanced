// <copyright file="Person.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.Person
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Person Class for Defining Classes Exercise
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Person name
        /// </summary>
        private string name;

        /// <summary>
        /// Person age
        /// </summary>
        private int age;

        /// <summary>
        /// Initializes a new instance of the Person class with default name and age.
        /// </summary>
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        /// <summary>
        /// Initializes a new instance of the Person class with user defined name and age.
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
            get => this.name;

            set
            {
                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("Person name must be between 2 and 50 characters.");
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets person age
        /// </summary>
        public int Age
        {
            get => this.age;

            set
            {
                if (value < 1 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("Person age must be between 1 and 120 years.");
                }

                this.age = value;
            }
        }

        /// <summary>
        /// Show Person information
        /// </summary>
        /// <returns>Returns string</returns>
        public string ShowInfo()
        {
            var sb = new StringBuilder();
            sb.Append("Name: ");
            sb.Append(this.Name);
            sb.Append(Environment.NewLine);
            sb.Append("Age: ");
            sb.Append(this.Age);

            return sb.ToString();
        }
    }
}
