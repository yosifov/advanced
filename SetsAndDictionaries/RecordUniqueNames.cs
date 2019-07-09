// <copyright file="RecordUniqueNames.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Record Unique Names Class for Sets and Dictionaries
    /// </summary>
    public class RecordUniqueNames
    {
        /// <summary>
        /// Execute Record Unique Names Task
        /// </summary>
        public static void Execute()
        {
            int lines = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();

            for (int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
