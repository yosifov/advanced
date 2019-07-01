namespace Advanced.FilesAndDirectories.EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    class EvenLines
    {
        public static void Execute()
        {
            using (var reader = new StreamReader("../../../FilesAndDirectories/EvenLines/text.txt"))
            {
                using (var writer = new StreamWriter("../../../FilesAndDirectories/EvenLines/Output.txt"))
                {
                    var line = reader.ReadLine();
                    int counter = 1;
                    while (line != null)
                    {
                        if (counter % 2 != 0)
                        {
                            var words = line
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => Regex.Replace(x, @"[-,.!?]{1}", "@"))
                            .Reverse()
                            .ToList();

                            writer.WriteLine(string.Join(" ", words));
                        }

                        counter++;
                        line = reader.ReadLine();
                    }

                }
            }
        }
    }
}
