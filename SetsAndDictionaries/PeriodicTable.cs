namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PeriodicTable
    {
        public static void Execute()
        {
            int lines = int.Parse(Console.ReadLine());
            var uniqueElements = new SortedSet<string>();

            for (int i = 0; i < lines; i++)
            {
                var elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var element in elements)
                {
                    uniqueElements.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", uniqueElements));
        }
    }
}
