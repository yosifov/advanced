// <copyright file="CustomMinFunction.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Custom Min Function Class for Functional Prgramming Exercise
    /// </summary>
    public class CustomMinFunction
    {
        /// <summary>
        /// Execute Custom Min Function Task
        /// </summary>
        public static void Execute()
        {
            Func<List<int>, int> minNumber = x => x.Min();
            Action<List<int>> print = x => Console.WriteLine(minNumber(x));

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            print(numbers);
        }
    }
}