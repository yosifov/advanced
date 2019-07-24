// <copyright file="StartUp.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.Car
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Startup Class for Car Class in Defining Classes Lab
    /// </summary>
    public class StartUp
    {
        /// <summary>
        /// Execute Car Class Task
        /// </summary>
        public static void Execute()
        {
            var tires = new List<Tire[]>();
            var engines = new List<Engine>();
            var cars = new List<Car>();
            var specialCars = new List<Car>();

            string input = Console.ReadLine();

            while (input != "No more tires")
            {
                int firstTireYear = int.Parse(input.Split()[0]);
                double firstTirePressure = double.Parse(input.Split()[1]);
                int secondTireYear = int.Parse(input.Split()[2]);
                double secondTirePressure = double.Parse(input.Split()[3]);
                int thirdTireYear = int.Parse(input.Split()[4]);
                double thirdTirePressure = double.Parse(input.Split()[5]);
                int fourthTireYear = int.Parse(input.Split()[6]);
                double fourthTirePressure = double.Parse(input.Split()[7]);

                var currentTires = new Tire[4]
                {
                    new Tire(firstTireYear, firstTirePressure),
                    new Tire(secondTireYear, secondTirePressure),
                    new Tire(thirdTireYear, thirdTirePressure),
                    new Tire(fourthTireYear, fourthTirePressure),
                };

                tires.Add(currentTires);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Engines done")
            {
                int engineHp = int.Parse(input.Split()[0]);
                double engineCapacity = double.Parse(input.Split()[1]);

                engines.Add(new Engine(engineHp, engineCapacity));

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Show special")
            {
                string carMake = input.Split()[0];
                string carModel = input.Split()[1];
                int carYear = int.Parse(input.Split()[2]);
                double carFuelQuantity = double.Parse(input.Split()[3]);
                double carFuelConsumption = double.Parse(input.Split()[4]);
                int carEngineIndex = int.Parse(input.Split()[5]);
                int carTiresIndex = int.Parse(input.Split()[6]);

                cars.Add(new Car(carMake, carModel, carYear, carFuelQuantity, carFuelConsumption, engines[carEngineIndex], tires[carTiresIndex]));

                input = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                double tirePressureSum = 0;

                foreach (var tire in car.Tires)
                {
                    tirePressureSum += tire.Pressure;
                }

                if (car.Year >= 2017
                    && car.Engine.HorsePower >= 330
                    && (tirePressureSum >= 9 || tirePressureSum <= 10))
                {
                    car.Drive(20);
                    specialCars.Add(car);
                }
            }

            foreach (var car in specialCars)
            {
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}