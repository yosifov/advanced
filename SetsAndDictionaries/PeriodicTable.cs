// <copyright file="PeriodicTable.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Periodic Table Class for Sets and Dictionaries
    /// </summary>
    public class PeriodicTable
    {
        /// <summary>
        /// Execute Periodic Table Task
        /// </summary>
        public static void Execute()
        {
            int lines = int.Parse(Console.ReadLine());
            var uniqueElements = new SortedSet<string>();

            for (int i = 0; i < lines; i++)
            {
                var elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var element in elements)
                {
                    uniqueElements.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", uniqueElements));
        }
    }
}
