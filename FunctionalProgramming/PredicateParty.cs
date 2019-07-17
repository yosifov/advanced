// <copyright file="PredicateParty.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Predicate Party Class for Functional Programming Exercise
    /// </summary>
    public class PredicateParty
    {
        /// <summary>
        /// Execute Predicate Party Task
        /// </summary>
        public static void Execute()
        {
            var sb = new StringBuilder();

            var partyPeople = Console.ReadLine()
                .Split()
                .ToList();

            string command = Console.ReadLine();

            while (command.ToLower() != "party!")
            {
                string action = command.Split()[0];
                string criteria = command.Split()[1];
                string str = command.Split()[2];

                Predicate<string> checkStart = x => x.StartsWith(str);
                Predicate<string> checkEnd = x => x.EndsWith(str);
                Predicate<string> checkLength = x => x.Length == int.Parse(str);

                switch (action.ToLower())
                {
                    case "remove":
                        if (criteria.ToLower() == "startswith")
                        {
                            partyPeople.RemoveAll(checkStart);
                        }
                        else if (criteria.ToLower() == "endswith")
                        {
                            partyPeople.RemoveAll(checkEnd);
                        }
                        else
                        {
                            partyPeople.RemoveAll(checkLength);
                        }

                        break;
                    case "double":
                        var guestsToAdd = new List<string>();
                        if (criteria.ToLower() == "startswith")
                        {
                            guestsToAdd = partyPeople.Where(x => checkStart(x)).ToList();
                        }
                        else if (criteria.ToLower() == "endswith")
                        {
                            guestsToAdd = partyPeople.Where(x => checkEnd(x)).ToList();
                        }
                        else
                        {
                            guestsToAdd = partyPeople.Where(x => checkLength(x)).ToList();
                        }

                        foreach (var name in guestsToAdd)
                        {
                            var index = partyPeople.IndexOf(name);

                            partyPeople.Insert(index, name);
                        }
                            
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            if (partyPeople.Count > 0)
            {
                sb.AppendJoin(", ", partyPeople);
                sb.Append(" are going to the party!");
                Console.WriteLine(sb);
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}