// <copyright file="ParkingLot.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Parking Lot Class for Sets and Dictionaries
    /// </summary>
    public class ParkingLot
    {
        /// <summary>
        /// Execute Parking Lot Task
        /// </summary>
        public static void Execute()
        {
            var parkedCars = new HashSet<string>();
            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                var inputParts = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = inputParts[0];
                string carNumber = inputParts[1];

                switch (direction.ToLower())
                {
                    case "in":
                        parkedCars.Add(carNumber);
                        break;
                    case "out":
                        parkedCars.Remove(carNumber);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            if (parkedCars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parkedCars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
