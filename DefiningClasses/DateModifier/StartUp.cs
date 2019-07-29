// <copyright file="StartUp.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.DateModifier
{
    using System;

    /// <summary>
    /// StartUp Class for Date Modifier Task in Defining Classes Exercise
    /// </summary>
    public class StartUp
    {
        /// <summary>
        /// Execute Date Modifier Task for Defining Classes Exercise
        /// </summary>
        public static void Execute()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            var timeInterval = new DateModifier(firstDate, secondDate);

            Console.WriteLine(timeInterval.DaysDifference());
        }
    }
}
