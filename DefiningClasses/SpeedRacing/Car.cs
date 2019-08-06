// <copyright file="Car.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Car class for Speed Racing task in Defining Classes exercise
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Initializes a new instance of the Car class with default values.
        /// </summary>
        public Car()
        {
            this.Model = string.Empty;
            this.FuelAmount = 0;
            this.FuelConsumption = 0;
            this.Distance = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Car class with user defined model, fuel amount and fuel consumption.
        /// </summary>
        /// <param name="model">Car model</param>
        /// <param name="fuelAmount">Car fuel amount</param>
        /// <param name="fuelConsumption">Car fuel consumption</param>
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.Distance = 0;
        }

        /// <summary>
        /// Gets or sets car model
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets car fuel amount
        /// </summary>
        public double FuelAmount { get; set; }

        /// <summary>
        /// Gets or sets car fuel consumption
        /// </summary>
        public double FuelConsumption { get; set; }

        /// <summary>
        /// Gets or sets car distance
        /// </summary>
        public double Distance { get; set; }

        /// <summary>
        /// Drive the car in distance
        /// </summary>
        /// <param name="distance">Distance to drive</param>
        public void Drive(double distance)
        {
            if (this.FuelAmount / this.FuelConsumption >= distance)
            {
                this.Distance += distance;
                this.FuelAmount -= distance * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        /// <summary>
        /// Print Car information
        /// </summary>
        public void GetCarInfo()
        {
            Console.WriteLine($"{this.Model} {this.FuelAmount:F2} {this.Distance}");
        }
    }
}
