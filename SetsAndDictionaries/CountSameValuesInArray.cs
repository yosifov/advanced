// <copyright file="CountSameValuesInArray.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Count Same Values in Array Class for Sets and Dictionaries
    /// </summary>
    public class CountSameValuesInArray
    {
        /// <summary>
        /// Execute Count Same Values in Array Task
        /// </summary>
        public static void Execute()
        {
            var inputs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var numbers = new Dictionary<double, int>();

            foreach (var input in inputs)
            {
                if (!numbers.ContainsKey(input))
                {
                    numbers.Add(input, 0);
                }

                numbers[input]++;
            }

            foreach (var kvp in numbers)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}