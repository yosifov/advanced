// <copyright file="AverageStudentGrades.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Average Student Grades Class for Sets and Dictionaries
    /// </summary>
    public class AverageStudentGrades
    {
        /// <summary>
        /// Execute Average Student Grades Task
        /// </summary>
        public static void Execute()
        {
            int lines = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string studentName = input[0];
                double studentGrade = double.Parse(input[1]);
                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }

                students[studentName].Add(studentGrade);
            }

            foreach (var kvp in students)
            {
                Console.WriteLine($"{kvp.Key} -> {string.Concat(kvp.Value.Select(x => string.Format("{0:F2} ", x)))}(avg: {kvp.Value.Average():F2})");
            }
        }
    }
}