// <copyright file="TruckTour.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.StacksAndQueues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Truck Tour Class for Stacks and Queues
    /// </summary>
    public class TruckTour
    {
        /// <summary>
        /// Execute Truck Tour Task
        /// </summary>
        public static void Execute()
        {
            int pumpsCount = int.Parse(Console.ReadLine());

            var pumps = new Queue<int>();

            for (int i = 0; i < pumpsCount; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int petrolAmount = input[0];
                int distance = input[1];

                pumps.Enqueue(petrolAmount - distance);
            }

            int index = 0;

            while (true)
            {
                var pumpsCopy = new Queue<int>(pumps);

                int fuel = -1;

                while (pumpsCopy.Any())
                {
                    if (pumpsCopy.Peek() > 0 && fuel == -1)
                    {
                        fuel = pumpsCopy.Dequeue();
                        pumps.Enqueue(pumps.Dequeue());
                    }
                    else if (pumpsCopy.Peek() < 0 && fuel == -1)
                    {
                        pumpsCopy.Enqueue(pumpsCopy.Dequeue());
                        pumps.Enqueue(pumps.Dequeue());
                        index++;
                    }
                    else
                    {
                        fuel += pumpsCopy.Dequeue();
                        if (fuel < 0)
                        {
                            break;
                        }
                    }
                }

                if (fuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }

                index++;
            }
        }
    }
}
