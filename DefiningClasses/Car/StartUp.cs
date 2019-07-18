// <copyright file="StartUp.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.Car
{
    using System;

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
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            var firstCar = new Car();
            var secondCar = new Car(make, model, year);
            var thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            Console.WriteLine(firstCar.WhoAmI());
            Console.WriteLine(secondCar.WhoAmI());
            Console.WriteLine(thirdCar.WhoAmI());
        }
    }
}
