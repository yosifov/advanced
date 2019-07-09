// <copyright file="LineNumbers2.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FilesAndDirectories.LineNumbers2
{
    using System.IO;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Line Numbers 2 Class for Files and Directories
    /// </summary>
    public class LineNumbers2
    {
        /// <summary>
        /// Execute the Line Numbers 2 Task for Files and Directories
        /// </summary>
        public static void Execute()
        {
            using (var reader = new StreamReader("../../../FilesAndDirectories/LineNumbers2/text.txt"))
            {
                using (var writer = new StreamWriter("../../../FilesAndDirectories/LineNumbers2/output.txt"))
                {
                    int counter = 1;
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var lineCharsCount = Regex.Replace(line, @"[-,.!?' ]{1}", string.Empty).Length;
                        var linePunctCount = Regex.Replace(line, @"[\w ]", string.Empty).Length;

                        writer.WriteLine($"Line {counter}: {line} ({lineCharsCount})({linePunctCount})");

                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
