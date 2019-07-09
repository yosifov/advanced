// <copyright file="CountSymbols.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Count Symbols Class for Sets and Dictionaries
    /// </summary>
    public class CountSymbols
    {
        /// <summary>
        /// Execute Count Symbols Task
        /// </summary>
        public static void Execute()
        {
            string input = Console.ReadLine();
            var charCounter = new SortedDictionary<char, int>();

            foreach (var character in input)
            {
                if (!charCounter.ContainsKey(character))
                {
                    charCounter.Add(character, 0);
                }

                charCounter[character]++;
            }

            foreach (var character in charCounter)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
