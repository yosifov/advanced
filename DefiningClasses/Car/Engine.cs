// <copyright file="Engine.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.Car
{
    using System;

    /// <summary>
    /// Engine Class for Defining Classes Lab
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Engine Horse Power
        /// </summary>
        private int horsePower;

        /// <summary>
        /// Engine Cubic Capacity
        /// </summary>
        private double cubicCapacity;

        /// <summary>
        /// Initializes a new instance of the Engine class and sets horsePower and cubicCapacity
        /// </summary>
        /// <param name="horsePower">Engine Horse Power</param>
        /// <param name="cubicCapacity">Engine Cubic Capacity</param>
        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        /// <summary>
        /// Gets or sets engine horse power
        /// </summary>
        public int HorsePower
        {
            get => this.horsePower;
        
            set
            {
                if (value < 10 || value >= 2000)
                {
                    throw new ArgumentException("Engine Horse Power must be between 10 and 2000 hp.");
                }

                this.horsePower = value;
            }
        }

        /// <summary>
        /// Gets or sets engine cubic capacity
        /// </summary>
        public double CubicCapacity
        {
            get => this.cubicCapacity;

            set
            {
                if (value < 0.6 || value > 9)
                {
                    throw new ArgumentException("Engine Capacity must be between 600 and 9000 cubic cm.");
                }

                this.cubicCapacity = value;
            }
        }
    }
}
