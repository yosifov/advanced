// <copyright file="WordCount.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FilesAndDirectories.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// Word Count Class for Files and Directories
    /// </summary>
    public class WordCount
    {
        /// <summary>
        /// Execute Word Count Task
        /// </summary>
        public static void Execute()
        {
            var wordsCount = new Dictionary<string, int>();
            var words = new List<string>();
            using (var reader = new StreamReader("../../../FilesAndDirectories/WordCount/words.txt"))
            {
                words = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                wordsCount = words.ToDictionary(x => x, y => 0);
            }

            using (var reader = new StreamReader("../../../FilesAndDirectories/WordCount/Input.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    foreach (var word in words)
                    {
                        if (line.ToLower().Contains(word.ToLower()))
                        {
                            wordsCount[word]++;
                        }
                    }

                    line = reader.ReadLine();
                }
            }

            using (var writer = new StreamWriter("../../../FilesAndDirectories/WordCount/Output.txt"))
            {
                foreach (var kvp in wordsCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}
