// <copyright file="DiagonalDifference.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.MultidimensionalArrays
{
    using System;
    using System.Linq;

    /// <summary>
    /// Diagonal Difference Class for Multidimensional Arrays
    /// </summary>
    public class DiagonalDifference
    {
        /// <summary>
        /// Execute Diagonal Difference Task
        /// </summary>
        public static void Execute()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            var matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                var matrixtRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = matrixtRow[j];
                }
            }

            int primaryDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                primaryDiagonal += matrix[row, row];
            }

            int secondaryDiagonal = 0;

            int currentRow = 0;
            int currentCol = matrix.GetLength(0) - 1;
            while (true)
            {
                if (currentRow >= matrix.GetLength(0)
                    || currentCol < 0)
                {
                    break;
                }

                secondaryDiagonal += matrix[currentRow, currentCol];
                currentRow++;
                currentCol--;
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
