// <copyright file="CustomComparator.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Custom Comparator Class for Functional Programming Exercise
    /// </summary>
    public class CustomComparator
    {
        /// <summary>
        /// Execute Custom Comparator Task
        /// </summary>
        public static void Execute()
        {
            Func<int, bool> selectEvenNumbers = x => x % 2 == 0;
            Func<int, bool> selectOddNumbers = x => x % 2 != 0;
            Action<List<int>> printSorted = x => Console.WriteLine(string.Join(" ", x));

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var evenNumbers = numbers
                .Where(selectEvenNumbers)
                .OrderBy(n => n)
                .ToList();

            var oddNumbers = numbers
                .Where(selectOddNumbers)
                .OrderBy(n => n)
                .ToList();

            var resultNumbers = new List<int>();
            resultNumbers.AddRange(evenNumbers);
            resultNumbers.AddRange(oddNumbers);

            printSorted(resultNumbers);
        }
    }
}
