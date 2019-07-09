// <copyright file="Miner.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.MultidimensionalArrays
{
    using System;
    using System.Linq;

    /// <summary>
    /// Miner Class for Multidimensional Arrays
    /// </summary>
    public class Miner
    {
        /// <summary>
        /// Execute Miner Task
        /// </summary>
        public static void Execute()
        {
            int fieldSize = int.Parse(Console.ReadLine());

            var field = new char[fieldSize][];

            var moves = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int coalCount = 0;
            int currentRow = -1;
            int currentCol = -1;
            bool reachEnd = false;

            for (int row = 0; row < fieldSize; row++)
            {
                field[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
            }

            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    if (field[row][col] == 'c')
                    {
                        coalCount++;
                    }
                    else if (field[row][col] == 's')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            foreach (var move in moves)
            {
                int rowDirection = 0;
                int colDirection = 0;

                switch (move)
                {
                    case "up":
                        rowDirection--;
                        break;
                    case "down":
                        rowDirection++;
                        break;
                    case "left":
                        colDirection--;
                        break;
                    case "right":
                        colDirection++;
                        break;
                    default:
                        break;
                }

                GetCurrentPosition(fieldSize, ref rowDirection, ref colDirection, ref currentRow, ref currentCol);

                switch (field[currentRow][currentCol])
                {
                    case 'c':
                        coalCount--;
                        field[currentRow][currentCol] = '*';
                        break;
                    case 'e':
                        reachEnd = true;
                        break;
                    default:
                        break;
                }

                if (reachEnd || coalCount == 0)
                {
                    break;
                }
            }

            if (reachEnd)
            {
                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
            }
            else if (coalCount > 0)
            {
                Console.WriteLine($"{coalCount} coals left. ({currentRow}, {currentCol})");
            }
            else
            {
                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
            }
        }

        /// <summary>
        /// Gets the current position of the miner
        /// </summary>
        /// <param name="fieldSize">Size of the field</param>
        /// <param name="rowDirection">Moving direction by row</param>
        /// <param name="colDirection">Moving direction by col</param>
        /// <param name="currentRow">Current position row index</param>
        /// <param name="currentCol">Current position col index</param>
        private static void GetCurrentPosition(int fieldSize, ref int rowDirection, ref int colDirection, ref int currentRow, ref int currentCol)
        {
            rowDirection = currentRow + rowDirection >= 0 ? rowDirection : 0;
            rowDirection = currentRow + rowDirection < fieldSize ? rowDirection : 0;
            colDirection = currentCol + colDirection >= 0 ? colDirection : 0;
            colDirection = currentCol + colDirection < fieldSize ? colDirection : 0;

            currentRow += rowDirection;
            currentCol += colDirection;
        }
    }
}