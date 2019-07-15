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

            Func<int, int> addOne = x => x + 1;
            Func<int, int> multiplyByTwo = x => x * 2;
            Func<int, int> substractOne = x => x - 1;

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
                        numbers = numbers.Select(substractOne).ToList();
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}