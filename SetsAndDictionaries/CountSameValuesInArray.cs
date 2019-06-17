namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CountSameValuesInArray
    {
        public static void Execute()
        {
            var inputs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var numbers = new Dictionary<double, int>();

            foreach (var input in inputs)
            {
                if (!numbers.ContainsKey(input))
                {
                    numbers.Add(input, 0);
                }
                numbers[input]++;
            }

            foreach (var kvp in numbers)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}