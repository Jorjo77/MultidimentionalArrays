using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse).ToArray();
            int[,] matrix = ReadMatrix(size[0], size[1]);
            int winRow = 0;
            int winCol = 0;
            int maxSum = int.MinValue;
            int[,] matrixWinner = new int[3, 3];
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                        int sum = 0;

                        sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row+1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                        if (sum>maxSum)
                        {
                            maxSum = sum;
                            winRow = row;
                            winCol = col;
                        }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.Write(matrix[winRow, winCol] + " " + matrix[winRow, winCol +1] + " " + matrix[winRow, winCol + 2]);
            Console.WriteLine();
            Console.Write(matrix[winRow + 1, winCol] + " " + matrix[winRow + 1, winCol + 1] + " " + matrix[winRow + 1, winCol + 2]);
            Console.WriteLine();
            Console.Write(matrix[winRow + 2, winCol] + " " + matrix[winRow + 2, winCol + 1] + " " + matrix[winRow + 2, winCol + 2]);
        }
        private static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            return matrix;
        }
    }
}
