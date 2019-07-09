// <copyright file="KnightGame.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.MultidimensionalArrays
{
    using System;
    using System.Linq;

    /// <summary>
    /// Knight Game Class for Multidimensional Arrays
    /// </summary>
    public class KnightGame
    {
        /// <summary>
        /// Execute Knight Game Task
        /// </summary>
        public static void Execute()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            var matrix = new char[matrixSize][];
            var kingCounter = new int[matrixSize][];

            int kingsRemoved = 0;

            for (int row = 0; row < matrixSize; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
                kingCounter[row] = new int[matrixSize];
            }

            while (true)
            {
                CountKnights(matrixSize, matrix, kingCounter);

                if (NeedToRemoveKnight(kingCounter))
                {
                    var max = kingCounter.SelectMany((subArr, i) => subArr.Select((value, j) => new { i, j, value }))
                    .OrderByDescending(x => x.value)
                    .First();
                    int firstIndex = max.i;
                    int secondIndex = max.j;

                    matrix[firstIndex][secondIndex] = '0';
                    kingsRemoved++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(kingsRemoved);
        }

        /// <summary>
        /// Counts the knights that can hit another knights
        /// </summary>
        /// <param name="matrixSize">The size of the jagged array</param>
        /// <param name="matrix">Jagged array with chars. Represents the play field</param>
        /// <param name="kingCounter">Jagged array with integers. Store the count of knight that the current knight can hit.</param>
        private static void CountKnights(int matrixSize, char[][] matrix, int[][] kingCounter)
        {
            foreach (var row in kingCounter)
            {
                Array.Clear(row, 0, matrixSize);
            }

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (matrix[row][col] == 'K')
                    {
                        if (row + 2 < matrixSize && col + 1 < matrixSize && matrix[row + 2][col + 1] == 'K')
                        {
                            kingCounter[row + 2][col + 1]++;
                        }

                        if (row + 2 < matrixSize && col - 1 >= 0 && (matrix[row + 2][col - 1] == 'K'))
                        {
                            kingCounter[row + 2][col - 1]++;
                        }

                        if (row - 2 >= 0 && col + 1 < matrixSize && matrix[row - 2][col + 1] == 'K')
                        {
                            kingCounter[row - 2][col + 1]++;
                        }

                        if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2][col - 1] == 'K')
                        {
                            kingCounter[row - 2][col - 1]++;
                        }

                        if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1][col - 2] == 'K')
                        {
                            kingCounter[row - 1][col - 2]++;
                        }

                        if (row + 1 < matrixSize && col - 2 >= 0 && matrix[row + 1][col - 2] == 'K')
                        {
                            kingCounter[row + 1][col - 2]++;
                        }

                        if (row - 1 >= 0 && col + 2 < matrixSize && matrix[row - 1][col + 2] == 'K')
                        {
                            kingCounter[row - 1][col + 2]++;
                        }

                        if (row + 1 < matrixSize && col + 2 < matrixSize && matrix[row + 1][col + 2] == 'K')
                        {
                            kingCounter[row + 1][col + 2]++;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Check if there is a knight that can hit another knight
        /// </summary>
        /// <param name="checkMatrix">Jagged array with integers. </param>
        /// <returns>Returns true or false</returns>
        private static bool NeedToRemoveKnight(int[][] checkMatrix)
        {
            foreach (var row in checkMatrix)
            {
                if (row.Any(x => x > 0))
                {
                    return true;
                }
            }

            return false;
        }
    }
}