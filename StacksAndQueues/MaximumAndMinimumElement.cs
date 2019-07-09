// <copyright file="MaximumAndMinimumElement.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.StacksAndQueues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Maximum and Minimum Element Class for Stacks and Queues
    /// </summary>
    public class MaximumAndMinimumElement
    {
        /// <summary>
        /// Execute Maximum and Minimum Element Task
        /// </summary>
        public static void Execute()
        {
            int operationsCount = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();

            var numbers = new Stack<int>();

            for (int i = 0; i < operationsCount; i++)
            {
                int[] command = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                switch (command[0])
                {
                    case 1:
                        numbers.Push(command[1]);
                        break;
                    case 2:
                        if (numbers.Count > 0)
                        {
                            numbers.Pop();
                        }

                        break;
                    case 3:
                        if (numbers.Count > 0)
                        {
                            sb.AppendLine(numbers.Max().ToString());
                        }

                        break;
                    case 4:
                        if (numbers.Count > 0)
                        {
                            sb.AppendLine(numbers.Min().ToString());
                        }

                        break;
                    default:
                        break;
                }
            }

            sb.Append(string.Join(", ", numbers));

            Console.WriteLine(sb);
        }
    }
}
