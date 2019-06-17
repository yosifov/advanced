namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    class ProductShop
    {
        public static void Execute()
        {
            string command = Console.ReadLine();
            var shops = new SortedDictionary<string, Dictionary<string, double>>();
            while (command.ToLower() != "revision")
            {
                var commandParts = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = commandParts[0];
                string product = commandParts[1];
                double price = double.Parse(commandParts[2]);
                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, double>();
                }
                shops[shop][product] = price;

                command = Console.ReadLine();
            }

            foreach (var shopKvp in shops)
            {
                Console.WriteLine($"{shopKvp.Key}->");

                foreach (var productKvp in shopKvp.Value)
                {
                    Console.WriteLine($"Product: {productKvp.Key}, Price: {productKvp.Value}");
                }
            }
        }
    }
}