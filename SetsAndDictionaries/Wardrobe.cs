﻿// <copyright file="Wardrobe.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Wardrobe Class for Sets and Dictionaries
    /// </summary>
    public class Wardrobe
    {
        /// <summary>
        /// Execute Wardrobe Task
        /// </summary>
        public static void Execute()
        {
            int lines = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                string color = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[0];
                var clothes = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                foreach (var garment in clothes)
                {
                    if (!wardrobe[color].ContainsKey(garment))
                    {
                        wardrobe[color].Add(garment, 0);
                    }

                    wardrobe[color][garment]++;
                }
            }

            var searchedItem = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string searchedColor = searchedItem[0];
            string searchedGarment = searchedItem[1];

            PrintWardrobe(wardrobe, searchedColor, searchedGarment);
        }

        /// <summary>
        /// Prints the wardrobe collection filtered by color and garment
        /// </summary>
        /// <param name="wardrobe">Dictionary with string keys and integer values</param>
        /// <param name="color">Filtering color</param>
        /// <param name="garment">Filtering garment</param>
        private static void PrintWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, string color, string garment)
        {
            foreach (var colorKvp in wardrobe)
            {
                Console.WriteLine($"{colorKvp.Key} clothes:");
                foreach (var garmentKvp in colorKvp.Value)
                {
                    Console.Write($"* {garmentKvp.Key} - {garmentKvp.Value}");
                    if (colorKvp.Key == color && garmentKvp.Key == garment)
                    {
                        Console.WriteLine(" (found!)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
