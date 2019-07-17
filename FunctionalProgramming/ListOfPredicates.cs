// <copyright file="ListOfPredicates.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of Predicates Class for Functional Programming Exercise
    /// </summary>
    public class ListOfPredicates
    {
        /// <summary>
        /// Execute List of Predicates Task
        /// </summary>
        public static void Execute()
        {
            int endOfRange = int.Parse(Console.ReadLine());

            var numbersInRange = Enumerable.Range(1, endOfRange).ToList();

            var dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Func<int, List<int>, bool> divideCheck = (x, y) =>
            {
                bool check = true;
                foreach (var item in y)
                {
                    if (x % item != 0)
                    {
                        check = false;
                    }
                }

                return check;
            };

            Action<List<int>> printList = x => Console.WriteLine(string.Join(" ", x));

            printList(numbersInRange.Where(x => divideCheck(x, dividers)).ToList());
        }
    }
}
