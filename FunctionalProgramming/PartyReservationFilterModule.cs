// <copyright file="PartyReservationFilterModule.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// PartyReservation Filter Module Class for Functional Programming Exercise
    /// </summary>
    public class PartyReservationFilterModule
    {
        /// <summary>
        /// Execute Party Reservation Filter Module Task
        /// </summary>
        public static void Execute()
        {
            var guests = Console.ReadLine()
                .Split()
                .ToList();

            string input = Console.ReadLine();
            var commands = new Dictionary<string, List<string>>();

            while (input.ToLower() != "print")
            {
                string command = input.Split(";")[0];
                string filterType = input.Split(";")[1];
                string filterParameter = input.Split(";")[2];

                if (command.ToLower() == "add filter")
                {
                    if (!commands.ContainsKey(filterType))
                    {
                        commands[filterType] = new List<string>();
                    }

                    commands[filterType].Add(filterParameter);
                }
                else if (command.ToLower() == "remove filter")
                {
                    commands[filterType].Remove(filterParameter);
                }

                input = Console.ReadLine();
            }

            FilterGuests(guests, commands);

            Console.WriteLine(string.Join(" ", guests));
        }

        /// <summary>
        /// Filters guests list by the given commands
        /// </summary>
        /// <param name="guests">List of guest</param>
        /// <param name="commands">List of commands</param>
        private static void FilterGuests(List<string> guests, Dictionary<string, List<string>> commands)
        {
            foreach (var kvp in commands)
            {
                switch (kvp.Key.ToLower())
                {
                    case "starts with":
                        guests.RemoveAll(r => kvp.Value.Any(f => r.StartsWith(f)));
                        break;
                    case "ends with":
                        guests.RemoveAll(r => kvp.Value.Any(f => r.EndsWith(f)));
                        break;
                    case "length":
                        guests.RemoveAll(r => kvp.Value.Any(f => r.Length >= int.Parse(f)));
                        break;
                    case "contains":
                        guests.RemoveAll(r => kvp.Value.Any(f => r.Contains(f)));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
