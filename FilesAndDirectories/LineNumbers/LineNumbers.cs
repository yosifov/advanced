namespace Advanced.FilesAndDirectories.LineNumbers
{
    using System.IO;

    class LineNumbers
    {
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
