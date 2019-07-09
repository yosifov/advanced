// <copyright file="EvenTimes.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Even Times Class for Sets and Dictionaries
    /// </summary>
    public class EvenTimes
    {
        /// <summary>
        /// Execute Even Times Task
        /// </summary>
        public static void Execute()
        {
            int lines = int.Parse(Console.ReadLine());
            var elements = new Dictionary<int, int>();

            for (int i = 0; i < lines; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!elements.ContainsKey(number))
                {
                    elements.Add(number, 0);
                }

                elements[number]++;
            }

            elements = elements.Where(x => x.Value % 2 == 0).ToDictionary(x => x.Key, x => x.Value);

            foreach (var element in elements)
            {
                Console.WriteLine(element.Key);
            }
        }
    }
}