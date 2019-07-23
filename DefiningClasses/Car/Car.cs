// <copyright file="Car.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.Car
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Car Class for Defining Classes Lab
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Car Make
        /// </summary>
        private string make;

        /// <summary>
        /// Car Model
        /// </summary>
        private string model;

        /// <summary>
        /// Car Year
        /// </summary>
        private int year;

        /// <summary>
        /// Car Fuel Quantity
        /// </summary>
        private double fuelQuantity;

        /// <summary>
        /// Car Fuel Consumption
        /// </summary>
        private double fuelConsumption;

        /// <summary>
        /// Car Engine
        /// </summary>
        private Engine engine;

        /// <summary>
        /// Car Tires
        /// </summary>
        private Tire[] tires;

        /// <summary>
        /// Initializes a new instance of the Car class with default values
        /// </summary>
        public Car()
        {
            this.Make = "Opel";
            this.Model = "Astra";
            this.Year = 2000;
            this.FuelConsumption = 9;
            this.FuelQuantity = 52;
        }

        /// <summary>
        /// Initializes a new instance of the Car class with user defined make, model and year.
        /// </summary>
        /// <param name="make">Car make</param>
        /// <param name="model">Car model</param>
        /// <param name="year">Car year</param>
        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        /// <summary>
        /// Initializes a new instance of the Car class with user defined make, model, year, fuel quantity and fuel consumption.
        /// </summary>
        /// <param name="make">Car make</param>
        /// <param name="model">Car model</param>
        /// <param name="year">Car year</param>
        /// <param name="fuelQuantity">Car fuel quantity</param>
        /// <param name="fuelConsumption">Car fuel consumption</param>
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        /// <summary>
        /// Initializes a new instance of the Car class with user defined make, model, year, fuel quantity, fuel consumption, engine and tires.
        /// </summary>
        /// <param name="make">Car make</param>
        /// <param name="model">Car model</param>
        /// <param name="year">Car year</param>
        /// <param name="fuelQuantity">Car fuel quantity</param>
        /// <param name="fuelConsumption">Car fuel consumption</param>
        /// <param name="engine">Car engine</param>
        /// <param name="tires">Car tires</param>
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        /// <summary>
        /// Gets or sets Car Make
        /// </summary>
        public string Make
        {
            get => this.make;

            set
            {
                if (value.Length <= 1)
                {
                    throw new ArgumentException("Car Make must be at least 2 characters.");
                }

                this.make = value;
            }
        }

        /// <summary>
        /// Gets or sets Car Model
        /// </summary>
        public string Model
        {
            get => this.model;

            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Car Model must be at least 1 character.");
                }

                this.model = value;
            }
        }

        /// <summary>
        /// Gets or sets Car Year
        /// </summary>
        public int Year
        {
            get => this.year;

            set
            {
                if (value <= 1900 || value > 2030)
                {
                    throw new ArgumentOutOfRangeException("Car Year must be between 1900 and 2030 year.");
                }

                this.year = value;
            }
        }

        /// <summary>
        /// Gets or sets Fuel Quantity
        /// </summary>
        public double FuelQuantity
        {
            get => this.fuelQuantity;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel Quantity can't be below 0 liters.");
                }

                this.fuelQuantity = value;
            }
        }

        /// <summary>
        /// Gets or sets Fuel Consumption
        /// </summary>
        public double FuelConsumption
        {
            get => this.fuelConsumption;

            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("Fuel Consumption must be between 1 and 50 liters per km.");
                }

                this.fuelConsumption = value;
            }
        }

        /// <summary>
        /// Gets or sets Car engine
        /// </summary>
        public Engine Engine { get; set; }

        /// <summary>
        /// Gets or sets Car tires
        /// </summary>
        public Tire[] Tires { get; set; }

        /// <summary>
        /// Drives the car if there is enough fuel left
        /// </summary>
        /// <param name="distance">Distance to drive</param>
        public void Drive(double distance)
        {
            if (this.FuelQuantity - (distance * this.FuelConsumption) < 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
            }
        }

        /// <summary>
        /// Gets the car information
        /// </summary>
        /// <returns>Car information</returns>
        public string WhoAmI()
        {
            var tires = new StringBuilder();

            foreach (var tire in this.Tires)
            {
                tires.Append("Year: ");
                tires.Append(tire.Year);
                tires.Append(" ");
                tires.Append("Pressure: ");
                tires.Append(tire.Pressure);
                tires.Append(Environment.NewLine);
            }

            return $"Make: {this.Make}\n" +
                $"Model: {this.Model}\n" +
                $"Year: {this.Year}\n" +
                $"Fuel: {this.FuelQuantity:F2}L\n" +
                $"Engine Horse Power: {this.Engine.HorsePower}\n" +
                $"Engine Cubic Capacity: {this.Engine.CubicCapacity}\n" +
                $"Tires: \n {tires}";
        }
    }
}