﻿// <copyright file="SetsOfElements.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Sets of Elements Class for Sets and Dictionaries
    /// </summary>
    public class SetsOfElements
    {
        /// <summary>
        /// Execute Sets of Elements Task 
        /// </summary>
        public static void Execute()
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstSetLength = input[0];
            int secondSetLength = input[1];

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetLength; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < secondSetLength; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            var commonElements = firstSet.Intersect(secondSet).ToHashSet();

            Console.WriteLine(string.Join(" ", commonElements));
        }
    }
}
