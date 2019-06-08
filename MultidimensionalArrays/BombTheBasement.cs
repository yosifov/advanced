namespace Advanced.MultidimensionalArrays
{
    using System;
    using System.Linq;

    class BombTheBasement
    {
        public static void Execute()
        {
            var matrixDimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];

            var matrix = new int[rows, cols];

            var inpact = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int inpactRow = inpact[0];
            int inpactCol = inpact[1];
            int inpactRadius = inpact[2];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - inpactRow, 2) + Math.Pow(col - inpactCol, 2));

                    if (distance <= inpactRadius)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }

            var secondMatrix = new int[cols][];

            for (int row = 0; row < cols; row++)
            {
                secondMatrix[row] = new int[rows];

                for (int col = 0; col < rows; col++)
                {
                    secondMatrix[row][col] = matrix[col, row];
                }
                secondMatrix[row] = secondMatrix[row].OrderByDescending(x => x).ToArray();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = secondMatrix[col][row];
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
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
