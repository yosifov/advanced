// <copyright file="FindEvensOrOdds.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Find Evens or Odds Class for Functional Programming Exercise
    /// </summary>
    public class FindEvensOrOdds
    {
        /// <summary>
        /// Execute Find Evens or Odds Task
        /// </summary>
        public static void Execute()
        {
            var range = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            Predicate<int> filter = x => command == "odd" ? x % 2 != 0 : x % 2 == 0;

            var resultNumbers = new List<int>();

            for (int i = range[0]; i <= range[1]; i++)
            {
                resultNumbers.Add(i);
            }

            Console.WriteLine(string.Join(" ", resultNumbers.Where(x => filter(x))));
        }
    }
}
