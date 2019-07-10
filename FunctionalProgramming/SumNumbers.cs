// <copyright file="SumNumbers.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Linq;

    /// <summary>
    /// Sum Numbers Class for Functional Programming Lab
    /// </summary>
    public class SumNumbers
    {
        /// <summary>
        /// Execute Sum Numbers Task
        /// </summary>
        public static void Execute()
        {
            Func<string, int> parser = n => int.Parse(n);

            var numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToArray();

            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
    }
}