// <copyright file="Employee.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Employee Class for Defining Classes Exercise
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Employee name
        /// </summary>
        private string name;

        /// <summary>
        /// Employee salary
        /// </summary>
        private double salary;

        /// <summary>
        /// Employee position
        /// </summary>
        private string position;

        /// <summary>
        /// Employee department
        /// </summary>
        private string department;

        /// <summary>
        /// Employee email
        /// </summary>
        private string email = "n/a";

        /// <summary>
        /// Employee age
        /// </summary>
        private int age = -1;

        /// <summary>
        /// Initializes a new instance of the Employee class with user defined name, salary, position and department.
        /// </summary>
        /// <param name="name">Employee name</param>
        /// <param name="salary">Employee salary</param>
        /// <param name="position">Employee position</param>
        /// <param name="department">Employee department</param>
        public Employee(string name, double salary, string position, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
        }

        /// <summary>
        /// Initializes a new instance of the Employee class with user defined name, salary, position, department, email and age.
        /// </summary>
        /// <param name="name">Employee name</param>
        /// <param name="salary">Employee salary</param>
        /// <param name="position">Employee position</param>
        /// <param name="department">Employee department</param>
        /// <param name="email">Employee email</param>
        /// <param name="age">Employee age</param>
        public Employee(string name, double salary, string position, string department, string email, int age)
            : this(name, salary, position, department)
        {
            this.Email = email;
            this.Age = age;
        }

        /// <summary>
        /// Gets or sets employee name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets employee salary
        /// </summary>
        public double Salary { get; set; }

        /// <summary>
        /// Gets or sets employee position
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets employee department
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Gets or sets employee email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets employee age
        /// </summary>
        public int Age { get; set; }
    }
}
