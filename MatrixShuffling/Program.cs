using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int row = sizes[0];
            int col = sizes[1];
            string[,] matrix = ReadMatrix(row, col);

            while (true)
            {
                string command = Console.ReadLine();
                if (command=="END")
                {
                    break;
                }

                if (!IsValidCommand(command, row, col))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string[] commands = command.Split().ToArray();
                    int row1 = int.Parse(commands[1]);
                    int col1 = int.Parse(commands[2]);
                    int row2 = int.Parse(commands[3]);
                    int col2 = int.Parse(commands[4]);
                    string temp = matrix[row2, col2];
                    matrix[row2, col2] = matrix[row1, col1];
                    matrix[row1, col1] = temp;

                    PrintMatrix(matrix);
                }
            }
        }

        private static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            return matrix;
        }

        private static bool IsValidCommand(string command, int row, int col)
        {
            string[] commands = command.Split().ToArray();

            if (commands.Length==5&& commands[0] == "swap" && int.Parse(commands[1]) <= row&& int.Parse(commands[2]) <= col
                && int.Parse(commands[3]) <= row && int.Parse(commands[4]) <= col)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void PrintMatrix(string[,] matrix)
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
