// <copyright file="StartUp.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// StartUp Class for Company Roster Task in Defining Classes Exercise
    /// </summary>
    public class StartUp
    {
        /// <summary>
        /// Execute Company Roster Task for Defining Classes Exercise
        /// </summary>
        public static void Execute()
        {
            var departments = new List<Department>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                string name = input[0];
                double salary = double.Parse(input[1]);
                string position = input[2];
                string department = input[3];
                string email = "n/a";
                int age = -1;

                if (input.Length == 5)
                {
                    if (input[4].Contains("@"))
                    {
                        email = input[4];
                    }
                    else
                    {
                        age = int.Parse(input[4]);
                    }
                }
                else if (input.Length == 6)
                {
                    email = input[4];
                    age = int.Parse(input[5]);
                }

                if (!departments.Contains(departments.FirstOrDefault(x => x.Name == department)))
                {
                    departments.Add(new Department(department));
                }

                departments
                    .First(x => x.Name == department)
                    .AddEmployee(new Employee(name, salary, position, department, email, age));
            }

            departments = departments.OrderByDescending(x => x.AverageSalary()).ToList();

            var topDepartment = departments.FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {topDepartment.Name}");

            topDepartment.EmployeeInfo();
        }
    }
}
