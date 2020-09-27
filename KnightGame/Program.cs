using System;
using System.Linq;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] chessPlayground = ReadMatrix(size, size);
            int removementsCounter = 0;
            int maxAttacks = 0;
            int rowMaxAttaks = 0;
            int colMaxAttaks = 0;

            while (true)
            {

                bool IsAttaced = false;
                for (int row = 0; row < chessPlayground.GetLength(0); row++)
                {
                    for (int col = 0; col < chessPlayground.GetLength(1); col++)
                    {
                        if (chessPlayground[row, col] == 'K')
                        {
                            int attacksCounter = 0;
                            if (IsInside(chessPlayground, row - 1, col - 2) && chessPlayground[row - 1, col - 2] == 'K')
                            {
                                attacksCounter++;
                                IsAttaced = true;
                            }
                            if (IsInside(chessPlayground, row - 2, col - 1) && chessPlayground[row - 2, col - 1] == 'K')
                            {
                                attacksCounter++;
                                IsAttaced = true;
                            }
                            if (IsInside(chessPlayground, row + 1, col + 2) && chessPlayground[row + 1, col + 2] == 'K')
                            {
                                attacksCounter++;
                                IsAttaced = true;
                            }
                            if (IsInside(chessPlayground, row + 1, col - 2) && chessPlayground[row + 1, col - 2] == 'K')
                            {
                                attacksCounter++;
                                IsAttaced = true;
                            }
                            if (IsInside(chessPlayground, row + 2, col + 1) && chessPlayground[row + 2, col + 1] == 'K')
                            {
                                attacksCounter++;
                                IsAttaced = true;
                            }
                            if (IsInside(chessPlayground, row - 2, col - 1) && chessPlayground[row - 2, col - 1] == 'K')
                            {
                                attacksCounter++;
                                IsAttaced = true;
                            }
                            if (IsInside(chessPlayground, row - 1, col + 2) && chessPlayground[row - 1, col + 2] == 'K')
                            {
                                attacksCounter++;
                                IsAttaced = true;
                            }
                            if (IsInside(chessPlayground, row - 2, col + 1) && chessPlayground[row - 2, col + 1] == 'K')
                            {
                                attacksCounter++;
                                IsAttaced = true;
                            }

                            if (attacksCounter > maxAttacks)
                            {
                                maxAttacks = attacksCounter;
                                rowMaxAttaks = row;
                                colMaxAttaks = col;
                            }
                        }
                    }
                }
                if (IsAttaced)
                {
                    chessPlayground[rowMaxAttaks, colMaxAttaks] = '0';
                    removementsCounter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(removementsCounter);
        }
        private static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            return matrix;
        }
        private static bool IsInside(char[,] matrix, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetCol >= 0 && targetRow < matrix.GetLength(0) && targetCol < matrix.GetLength(1);
        }
    }
}
