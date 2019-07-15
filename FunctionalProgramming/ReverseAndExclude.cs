// <copyright file="ReverseAndExclude.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Linq;

    /// <summary>
    /// Reverse and Exclude Class for Functional Programming Exercise
    /// </summary>
    public class ReverseAndExclude
    {
        /// <summary>
        /// Execute Reverse and Exclude Task
        /// </summary>
        public static void Execute()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int divisionNumber = int.Parse(Console.ReadLine());

            Func<int, bool> division = x => x % divisionNumber != 0;

            Console.WriteLine(string.Join(" ", numbers.Where(division).Reverse()));
        }
    }
}