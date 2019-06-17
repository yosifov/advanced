namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    class ParkingLot
    {
        public static void Execute()
        {
            var parkedCars = new HashSet<string>();
            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                var inputParts = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = inputParts[0];
                string carNumber = inputParts[1];

                switch (direction.ToLower())
                {
                    case "in":
                        parkedCars.Add(carNumber);
                        break;
                    case "out":
                        parkedCars.Remove(carNumber);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            if (parkedCars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parkedCars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
