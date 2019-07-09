// <copyright file="ProductShop.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Product Shop Class for Sets and Dictionaries
    /// </summary>
    public class ProductShop
    {
        /// <summary>
        /// Execute Product Shop Task
        /// </summary>
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