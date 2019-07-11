// <copyright file="FilterByAge.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.FunctionalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Filter by Age Class for Functional Programming Lab
    /// </summary>
    public class FilterByAge
    {
        /// <summary>
        /// Execute Filter by Age Task
        /// </summary>
        public static void Execute()
        {
            int rows = int.Parse(Console.ReadLine());
            var people = new List<Person>();
            Action<Person> printFullPersonInfo = x => x.GetPersonInformation(x.Name, x.Age);
            Action<Person> printPersonName = x => x.GetPersonInformation(x.Name);
            Action<Person> printPersonAge = x => x.GetPersonInformation(x.Age);

            for (int i = 0; i < rows; i++)
            {
                var person = Console.ReadLine()
                    .Split(", ");
                string personName = person[0];
                int personAge = int.Parse(person[1]);
                people.Add(new Person(personName, personAge));
            }

            string condition = Console.ReadLine();
            int conditionAge = int.Parse(Console.ReadLine());
            string printFormat = Console.ReadLine();
            var filterResults = new List<Person>();

            if (condition.ToLower() == "older")
            {
                filterResults = people.Where(x => x.Age >= conditionAge).ToList();
            }
            else
            {
                filterResults = people.Where(x => x.Age < conditionAge).ToList();
            }

            switch (printFormat)
            {
                case "name age":
                    filterResults.ForEach(printFullPersonInfo);
                    break;
                case "name":
                    filterResults.ForEach(printPersonName);
                    break;
                case "age":
                    filterResults.ForEach(printPersonAge);
                    break;
                default:
                    break;
            }
        }
    }
}