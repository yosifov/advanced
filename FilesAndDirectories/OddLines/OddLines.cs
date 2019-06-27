namespace Advanced.FilesAndDirectories.OddLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    class OddLines
    {
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
