﻿// <copyright file="TwoByTwoSquaresInMatrix.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.MultidimensionalArrays
{
    using System;
    using System.Linq;

    /// <summary>
    /// Two by Two Squares in Matrix Class for Multidimensional Arrays
    /// </summary>
    public class TwoByTwoSquaresInMatrix
    {
        /// <summary>
        /// Execute Two by Two Squares in Matrix Task
        /// </summary>
        public static void Execute()
        {
            var matrixDimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];

            var matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int count = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row, col] == matrix[row + 1, col]
                        && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
