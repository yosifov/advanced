// <copyright file="UniqueUsernames.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Unique Usernames Class for Sets and Dictionaries
    /// </summary>
    public class UniqueUsernames
    {
        /// <summary>
        /// Execute Unique Usernames Task
        /// </summary>
        public static void Execute()
        {
            int lines = int.Parse(Console.ReadLine());
            var usernames = new HashSet<string>();

            for (int i = 0; i < lines; i++)
            {
                string username = Console.ReadLine();
                usernames.Add(username);
            }

            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
