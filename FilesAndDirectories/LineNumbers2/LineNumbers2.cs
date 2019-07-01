namespace Advanced.FilesAndDirectories.LineNumbers2
{
    using System.IO;
    using System.Text.RegularExpressions;

    class LineNumbers2
    {
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
                        var lineCharsCount = Regex.Replace(line, @"[-,.!?' ]{1}", "").Length;
                        var linePunctCount = Regex.Replace(line, @"[\w ]", "").Length;

                        writer.WriteLine($"Line {counter}: {line} ({lineCharsCount})({linePunctCount})");

                        counter++;
                        line = reader.ReadLine();
                    }

                }
            }
        }
    }
}
