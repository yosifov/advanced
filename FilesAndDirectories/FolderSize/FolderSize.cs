namespace Advanced.FilesAndDirectories.FolderSize
{
    using System;
    using System.IO;

    class FolderSize
    {
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
