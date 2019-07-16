// <copyright file="AppliedArithmetics.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Linq;

    /// <summary>
    /// Applied Arithmetic Class for Functional Programming Exercise
    /// </summary>
    public class AppliedArithmetics
    {
        /// <summary>
        /// Execute Applied Arithmetic Task
        /// </summary>
        public static void Execute()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            Func<int, int> addOne = x => ++x;
            Func<int, int> multiplyByTwo = x => x * 2;
            Func<int, int> subtractOne = x => --x;

            while (command.ToLower() != "end")
            {
                switch (command.ToLower())
                {
                    case "add":
                        numbers = numbers.Select(addOne).ToList();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    case "multiply":
                        numbers = numbers.Select(multiplyByTwo).ToList();
                        break;
                    case "subtract":
                        numbers = numbers.Select(subtractOne).ToList();
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}