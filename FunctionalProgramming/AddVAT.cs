// <copyright file="AddVAT.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Linq;

    /// <summary>
    /// Add VAT Class for Functional Programming Lab
    /// </summary>
    public class AddVAT
    {
        /// <summary>
        /// Execute Add VAT Task
        /// </summary>
        public static void Execute()
        {
            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x + x * 0.2)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x:F2}"));
        }
    }
}
