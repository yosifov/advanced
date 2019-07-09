// <copyright file="CitiesByContinentAndCountry.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Cities by Continent and Country Class for Sets and Dictionaries
    /// </summary>
    public class CitiesByContinentAndCountry
    {
        /// <summary>
        /// Execute Cities by Continent and Country Task
        /// </summary>
        public static void Execute()
        {
            int lines = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new Dictionary<string, List<string>>();
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent][country] = new List<string>();
                }

                continents[continent][country].Add(city);
            }

            foreach (var continentKvp in continents)
            {
                Console.WriteLine($"{continentKvp.Key}:");

                foreach (var countryKvp in continentKvp.Value)
                {
                    Console.WriteLine($"  {countryKvp.Key} -> {string.Join(", ", countryKvp.Value)}");
                }
            }
        }
    }
}