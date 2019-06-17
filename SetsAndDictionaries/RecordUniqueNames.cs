namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    class RecordUniqueNames
    {
        public static void Execute()
        {
            int lines = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();

            for (int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
