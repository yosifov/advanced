﻿// <copyright file="BasicQueueOperations.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.StacksAndQueues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Basic Queue Operations Class for Stacks and Queues
    /// </summary>
    public class BasicQueueOperations
    {
        /// <summary>
        /// Execute Basic Queue Operations Task
        /// </summary>
        public static void Execute()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxElementsToDequeue = input[1];
            int searchElement = input[2];

            var elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>(elements);

            int elementsToDequeue = Math.Min(queue.Count, maxElementsToDequeue);

            for (int i = 1; i <= elementsToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(searchElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count > 0)
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
