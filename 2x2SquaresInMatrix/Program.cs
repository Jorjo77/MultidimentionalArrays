using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse).ToArray();
            char[,] matrix = ReadMatrix(size[0], size[1]);
            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row >= 1&&col>=1)
                    {
                        if (matrix[row, col]== matrix[row, col -1]&&
                            matrix[row, col]== matrix[row -1, col]&&
                            matrix[row, col]== matrix[row -1, col -1])
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
        private static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            return matrix;
        }
    }
}
