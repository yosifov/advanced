// <copyright file="KnightsOfHonor.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Linq;

    /// <summary>
    /// Knights of Honor Class for Functional Programming Exercise
    /// </summary>
    public class KnightsOfHonor
    {
        /// <summary>
        /// Execute Knights of Honor Task
        /// </summary>
        public static void Exercise()
        {
            Action<string> printNameWithSir = x => Console.WriteLine($"Sir {x}");

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(printNameWithSir);
        }
    }
}