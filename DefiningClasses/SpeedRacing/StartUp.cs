// <copyright file="StartUp.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Startup Class for Speed Racing Task in Defining Classes Exercise
    /// </summary>
    public class StartUp
    {
        /// <summary>
        /// Execute Speed Racing Task for Defining Classes Exercise
        /// </summary>
        public static void Execute()
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string model = input.Split()[0];
                double fuelAmount = double.Parse(input.Split()[1]);
                double fuelConsumption = double.Parse(input.Split()[2]);

                if (!cars.Any(x => x.Model == model))
                {
                    cars.Add(new Car(model, fuelAmount, fuelConsumption));
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string model = command.Split()[1];
                double distance = double.Parse(command.Split()[2]);

                cars.FirstOrDefault(x => x.Model == model).Drive(distance);

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                car.GetCarInfo();
            }
        }
    }
}
