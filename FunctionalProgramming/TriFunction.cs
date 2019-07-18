// <copyright file="TriFunction.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Linq;

    /// <summary>
    /// TriFunction Class for Functional Programming Exercise
    /// </summary>
    public class TriFunction
    {
        /// <summary>
        /// Execute TriFunction Task
        /// </summary>
        public static void Execute()
        {
            int compareNumber = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, bool> checkName = x => x.ToCharArray().Select(y => (int)y).Sum() >= compareNumber;

            Console.WriteLine(names.FirstOrDefault(checkName));
        }
    }
}
