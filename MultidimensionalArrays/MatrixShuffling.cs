namespace Advanced.MultidimensionalArrays
{
    using System;
    using System.Linq;

    class MatrixShuffling
    {
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

            //string command = Console.ReadLine();
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

        private static void SwapMatrix(string[,] matrix, int row1, int col1, int row2, int col2)
        {
            string temp = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = temp;
        }

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