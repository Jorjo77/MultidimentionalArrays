using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = ReadMatrix(size, size);
            char symbol = char.Parse(Console.ReadLine());
            bool IsSymbolExist = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix [row, col]==symbol)
                    {
                        IsSymbolExist = true;
                        Console.WriteLine($"({row}, {col})");
                        break;
                    }
                }
            }
            if (IsSymbolExist== false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
        private static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            return matrix;
        }
    }
}
