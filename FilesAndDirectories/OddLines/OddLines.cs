// <copyright file="OddLines.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FilesAndDirectories.OddLines
{
    using System.IO;

    /// <summary>
    /// Odd Lines Class for Files and Directories
    /// </summary>
    public class OddLines
    {
        /// <summary>
        /// Execute Odd Lines Task
        /// </summary>
        public static void Execute()
        {
            using (var reader = new StreamReader("../../../FilesAndDirectories/OddLines/Input.txt"))
            {
                using (var writer = new StreamWriter("../../../FilesAndDirectories/OddLines/Output.txt"))
                {
                    var line = reader.ReadLine();
                    var counter = 0;

                    while (line != null)
                    {
                        if (counter % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }

                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
