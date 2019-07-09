// <copyright file="MaximalSum.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.MultidimensionalArrays
{
    using System;
    using System.Linq;

    /// <summary>
    /// Maximal Sum Class for Multidimensional Arrays
    /// </summary>
    public class MaximalSum
    {
        /// <summary>
        /// Execute Maximal Sum Task
        /// </summary>
        public static void Execute()
        {
            var matrixDimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int maxSum = int.MinValue;
            int bestRowIndex = 0;
            int bestColIndex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSum = matrix[row, col]
                        + matrix[row, col + 1]
                        + matrix[row, col + 2]
                        + matrix[row + 1, col]
                        + matrix[row + 1, col + 1]
                        + matrix[row + 1, col + 2]
                        + matrix[row + 2, col]
                        + matrix[row + 2, col + 1]
                        + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        bestRowIndex = row;
                        bestColIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = bestRowIndex; row < bestRowIndex + 3; row++)
            {
                for (int col = bestColIndex; col < bestColIndex + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}