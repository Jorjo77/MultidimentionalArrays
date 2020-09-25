using System;
using System.Linq;

namespace MultidimentionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // манипулиране с матрици: 
            // foreach за матрица почти не се използва
            //int[,] matrix = new int[3, 4];
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        matrix[row, col] = row + col;
            //        Console.Write(matrix[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // печатане на матрица в готов метод:
            //static void PrintMatrix(int[,] matrix)
            //{
            //    for (int row = 0; row < matrix.GetLength(0); row++)
            //    {
            //        for (int col = 0; col < matrix.GetLength(1); col++)
            //        {
            //            Console.Write(matrix[row, col] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            // сумиране на матрица в готов метод:
            //static int SumMatrix(int[,] matrix)
            //{
            //    int sum = 0;
            //    for (int row = 0; row < matrix.GetLength(0); row++)
            //    {
            //        for (int col = 0; col < matrix.GetLength(1); col++)
            //        {
            //            sum += matrix[row, col];
            //        }
            //    }
            //    return sum;
            //}

            //четене на матрица:
            //static int[,] ReadMatrix(int rows, int cols)
            //{
            //    int[,] matrix = new int[rows, cols];
            //    for (int row = 0; row < matrix.GetLength(0); row++)
            //    {
            //        int[] rowData = Console.ReadLine()
            //            .Split(" ")
            //            .Select(int.Parse).ToArray();
            //        for (int col = 0; col < matrix.GetLength(1); col++)
            //        {
            //            matrix[row, col] = rowData[col];
            //        }
            //    }
            //    return matrix;
            //}
        }
    }
}
