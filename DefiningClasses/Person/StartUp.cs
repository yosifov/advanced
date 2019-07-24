// <copyright file="StartUp.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.Person
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Startup Class for Person Task in Defining Classes Exercise
    /// </summary>
    public class StartUp
    {
        /// <summary>
        /// Execute StartUp Class
        /// </summary>
        public static void Execute()
        {
            int n = int.Parse(Console.ReadLine());
            var myFamily = new Family();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                string name = input.Split()[0];
                int age = int.Parse(input.Split()[1]);

                myFamily.AddMember(new Person(name, age));
            }

            var oldestMember = myFamily.GetOldestMember();

            Console.WriteLine($"Name: {oldestMember.Name}, Age: {oldestMember.Age}");
        }
    }
}
