namespace Advanced.FilesAndDirectories.MergeFiles
{
    using System.IO;

    class MergeFiles
    {
        public static void Execute()
        {
            using (var firstReader = new StreamReader("../../../FilesAndDirectories/MergeFiles/Input1.txt"))
            {
                using (var secondReader = new StreamReader("../../../FilesAndDirectories/MergeFiles/Input2.txt"))
                {
                    using (var writer = new StreamWriter("../../../FilesAndDirectories/MergeFiles/Output.txt"))
                    {

                        var firstFileLine = firstReader.ReadLine();
                        var secondFileLine = secondReader.ReadLine();
                        while (firstFileLine != null && secondFileLine != null)
                        {
                            if (firstFileLine != null)
                            {
                                writer.WriteLine(firstFileLine);
                            }
                            if (secondFileLine != null)
                            {
                                writer.WriteLine(secondFileLine);
                            }
                            firstFileLine = firstReader.ReadLine();
                            secondFileLine = secondReader.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
