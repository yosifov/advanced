// <copyright file="PredicateForNames.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Linq;

    /// <summary>
    /// Predicate for Names Class for Functional Programming Exercise
    /// </summary>
    public class PredicateForNames
    {
        /// <summary>
        /// Execute Predicate for Names Task
        /// </summary>
        public static void Execute()
        {
            int nameLength = int.Parse(Console.ReadLine());

            Func<string, bool> filterName = x => x.Length <= nameLength;

            var names = Console.ReadLine()
                .Split()
                .Where(filterName)
                .ToList();

            names.ForEach(Console.WriteLine);
        }
    }
}