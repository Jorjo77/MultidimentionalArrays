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
            int sum = 0;
            int maxSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row >= 2 && col >= 2)
                    {
                        sum += matrix[row, col];
                        sum += matrix[row, col - 1];
                        sum += matrix[row, col - 2];
                        sum += matrix[row - 1, col];
                        sum += matrix[row - 1, col - 1];
                        sum += matrix[row - 1, col - 2];
                        sum += matrix[row - 2, col];
                        sum += matrix[row - 2, col - 1];
                        sum += matrix[row - 2, col - 2];
                        if (sum>maxSum)
                        {
                            maxSum = sum;
                        }
                    }
                }
            }
            Console.WriteLine(maxSum);
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
