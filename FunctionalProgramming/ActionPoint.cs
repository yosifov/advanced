// <copyright file="ActionPoint.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Linq;

    /// <summary>
    /// Action Point Class for Functional Programming Exercise
    /// </summary>
    public class ActionPoint
    {
        /// <summary>
        /// Execute Action Point Task
        /// </summary>
        public static void Execute()
        {
            Action<string> printName = x => Console.WriteLine(x);

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(printName);
        }
    }
}