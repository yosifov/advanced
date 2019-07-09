// <copyright file="SnakeMoves.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.MultidimensionalArrays
{
    using System;
    using System.Linq;

    /// <summary>
    /// Snake Moves Class for Multidimensional Arrays
    /// </summary>
    public class SnakeMoves
    {
        /// <summary>
        /// Execute Snake Moves Task
        /// </summary>
        public static void Execute()
        {
            var matrixDimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];

            var matrix = new char[rows, cols];

            string snake = Console.ReadLine();

            int snakeIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = snake[snakeIndex];
                    snakeIndex++;
                    if (snakeIndex > snake.Length - 1)
                    {
                        snakeIndex = 0;
                    }
                }
            }

            PrintMatrix(matrix);
        }

        /// <summary>
        /// Prints two dimensional array
        /// </summary>
        /// <param name="matrix">Two dimensional array with chars</param>
        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
