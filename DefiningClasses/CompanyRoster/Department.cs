// <copyright file="Department.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Department Class for Defining Classes Exercise
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Department name
        /// </summary>
        private string name;

        /// <summary>
        /// Department list of employees
        /// </summary>
        private List<Employee> employees = new List<Employee>();

        /// <summary>
        /// Initializes a new instance of the Department class.
        /// </summary>
        /// <param name="name">Department name</param>
        public Department(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets department name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets department employees
        /// </summary>
        public List<Employee> Employees
        {
            get => this.employees;
            set
            {
                this.employees = new List<Employee>(value);
            }
        }

        /// <summary>
        /// Add employee to the department
        /// </summary>
        /// <param name="employee">Employee to add</param>
        public void AddEmployee(Employee employee)
        {
            this.Employees.Add(employee);
        }

        /// <summary>
        /// Return average salary
        /// </summary>
        /// <returns>Returns double</returns>
        public double AverageSalary()
        {
            return this.Employees.Average(x => x.Salary);
        }

        /// <summary>
        /// Print employees info from the department 
        /// </summary>
        public void EmployeeInfo()
        {
            foreach (var employee in this.Employees.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
