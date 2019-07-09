// <copyright file="FolderSize.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FilesAndDirectories.FolderSize
{
    using System.IO;
    
    /// <summary>
    /// Folder Size Class for Files and Directories
    /// </summary>
    public class FolderSize
    {
        /// <summary>
        /// Execute the Folder Size Task for Files and Directories
        /// </summary>
        public static void Execute()
        {
            var filesInDir = Directory.GetFiles("../../../FilesAndDirectories/FolderSize");
            double filesSize = 0;
            foreach (var file in filesInDir)
            {
                FileInfo fileInfo = new FileInfo(file);
                filesSize += (double)fileInfo.Length / 1024 / 1024;
            }

            using (var writer = new StreamWriter("../../../FilesAndDirectories/FolderSize/Output.txt"))
            {
                writer.Write(filesSize);
            }
        }
    }
}
