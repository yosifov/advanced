namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    class Wardrobe
    {
        public static void Execute()
        {
            int lines = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                string color = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[0];
                var clothes = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }
                foreach (var garment in clothes)
                {
                    if (!wardrobe[color].ContainsKey(garment))
                    {
                        wardrobe[color].Add(garment, 0);
                    }
                    wardrobe[color][garment]++;
                }
            }

            var searchedItem = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string searchedColor = searchedItem[0];
            string searchedGarment = searchedItem[1];

            PrintWardrobe(wardrobe, searchedColor, searchedGarment);
        }

        private static void PrintWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, string color, string garment)
        {
            foreach (var colorKvp in wardrobe)
            {
                Console.WriteLine($"{colorKvp.Key} clothes:");
                foreach (var garmentKvp in colorKvp.Value)
                {
                    Console.Write($"* {garmentKvp.Key} - {garmentKvp.Value}");
                    if (colorKvp.Key == color && garmentKvp.Key == garment)
                    {
                        Console.WriteLine(" (found!)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
