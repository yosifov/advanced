// <copyright file="CountUppercaseWords.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Linq;

    /// <summary>
    /// Count Uppercase Words Class for Functional Programming Lab
    /// </summary>
    public class CountUppercaseWords
    {
        /// <summary>
        /// Execute Count Uppercase Words Task
        /// </summary>
        public static void Execute()
        {
            Func<string, bool> parser = x => x[0] == x.ToUpper()[0];

            Console.ReadLine()
                .Split()
                .Where(parser)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}