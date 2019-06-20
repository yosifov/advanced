namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    class CountSymbols
    {
        public static void Execute()
        {
            string input = Console.ReadLine();
            var charCounter = new SortedDictionary<char, int>();

            foreach (var character in input)
            {
                if (!charCounter.ContainsKey(character))
                {
                    charCounter.Add(character, 0);
                }
                charCounter[character]++;
            }

            foreach (var character in charCounter)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
