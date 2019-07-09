// <copyright file="AutoRepairAndService.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.StacksAndQueues
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Auto Repair and Service Class for Stacks and Queues
    /// </summary>
    public class AutoRepairAndService
    {
        /// <summary>
        /// Execute Auto Repair and Service Task
        /// </summary>
        public static void Execute()
        {
            var input = Console.ReadLine().Split();
            var awaitingVehicles = new Queue<string>(input);
            var servedVehicles = new Stack<string>();

            string commands = Console.ReadLine();
            var sb = new StringBuilder();

            while (commands != "End")
            {
                string command = commands.Split("-")[0];
                switch (command)
                {
                    case "Service":
                        if (awaitingVehicles.Count != 0)
                        {
                            servedVehicles.Push(awaitingVehicles.Peek());
                            sb.AppendLine($"Vehicle {awaitingVehicles.Dequeue()} got served.");
                        }

                        break;
                    case "CarInfo":
                        string modelName = commands.Split("-")[1];
                        if (awaitingVehicles.Contains(modelName))
                        {
                            sb.AppendLine("Still waiting for service.");
                        }
                        else if (servedVehicles.Contains(modelName))
                        {
                            sb.AppendLine("Served.");
                        }

                        break;
                    case "History":
                        sb.AppendLine(string.Join(", ", servedVehicles));
                        break;
                    default:
                        break;
                }

                commands = Console.ReadLine();
            }

            if (awaitingVehicles.Count != 0)
            {
                sb.AppendLine($"Vehicles for service: {string.Join(", ", awaitingVehicles)}");
            }

            if (servedVehicles.Count != 0)
            {
                sb.AppendLine($"Served vehicles: {string.Join(", ", servedVehicles)}");
            }

            Console.WriteLine(sb);
        }
    }
}
