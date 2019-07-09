// <copyright file="MatrixShuffling.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.MultidimensionalArrays
{
    using System;
    using System.Linq;

    /// <summary>
    /// Matrix Shuffling Class for Multidimensional Arrays
    /// </summary>
    public class MatrixShuffling
    {
        /// <summary>
        /// Execute Matrix Shuffling Task
        /// </summary>
        public static void Execute()
        {
            var matrixDimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];

            var matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                var commandParts = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commandParts.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string action = commandParts[0];
                int row1 = int.Parse(commandParts[1]);
                int col1 = int.Parse(commandParts[2]);
                int row2 = int.Parse(commandParts[3]);
                int col2 = int.Parse(commandParts[4]);

                if (action != "swap"
                    || row1 > matrix.GetLength(0)
                    || col1 > matrix.GetLength(1)
                    || row2 > matrix.GetLength(0)
                    || col2 > matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                SwapMatrix(matrix, row1, col1, row2, col2);
                PrintMatrix(matrix);
            }
        }

        /// <summary>
        /// Swap two dimensional array cells with specified coordinates. 
        /// </summary>
        /// <param name="matrix">Two dimensional array</param>
        /// <param name="row1">Row index of first element</param>
        /// <param name="col1">Col index of first element</param>
        /// <param name="row2">Row element of second element</param>
        /// <param name="col2">Col index of second element</param>
        private static void SwapMatrix(string[,] matrix, int row1, int col1, int row2, int col2)
        {
            string temp = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = temp;
        }

        /// <summary>
        /// Prints the specified two dimensional array
        /// </summary>
        /// <param name="matrix">Two dimensional array</param>
        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}