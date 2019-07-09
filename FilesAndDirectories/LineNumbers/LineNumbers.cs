// <copyright file="LineNumbers.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FilesAndDirectories.LineNumbers
{
    using System.IO;

    /// <summary>
    /// Line Numbers Class for Files and Directories
    /// </summary>
    public class LineNumbers
    {
        /// <summary>
        /// Execute Line Numbers Task for Files and Directories
        /// </summary>
        public static void Execute()
        {
            using (var reader = new StreamReader("../../../FilesAndDirectories/LineNumbers/Input.txt"))
            {
                using (var writer = new StreamWriter("../../../FilesAndDirectories/LineNumbers/Output.txt"))
                {
                    var line = reader.ReadLine();
                    int counter = 1;

                    while (line != null)
                    {
                        writer.WriteLine($"{counter}. {line}");
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
