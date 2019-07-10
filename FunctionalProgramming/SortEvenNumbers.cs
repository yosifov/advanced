// <copyright file="SortEvenNumbers.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Linq;

    /// <summary>
    /// Sort Even Numbers Class for Functional Programming Lab
    /// </summary>
    public class SortEvenNumbers
    {
        /// <summary>
        /// Execute Sort Even Numbers Task
        /// </summary>
        public static void Execute()
        {
            var inputNumbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine(string.Join(", ", inputNumbers));
        }
    }
}