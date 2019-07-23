// <copyright file="Tire.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.Car
{
    using System;

    /// <summary>
    /// Tire Class for Defining Classes Lab
    /// </summary>
    public class Tire
    {
        /// <summary>
        /// Tire year
        /// </summary>
        private int year;

        /// <summary>
        /// Tire pressure
        /// </summary>
        private double pressure;

        /// <summary>
        /// Initializes a new instance of the Tire class and sets year and pressure
        /// </summary>
        /// <param name="year">Tire year</param>
        /// <param name="pressure">Tire pressure</param>
        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }

        /// <summary>
        /// Gets or sets tire year
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets tire pressure
        /// </summary>
        public double Pressure { get; set; }
    }
}
