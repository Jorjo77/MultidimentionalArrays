using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsNumber = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[rowsNumber][];

            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                double[] rowData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
                jaggedArray[row] = new double[rowData.Length];
                for (int col = 0; col < rowData.Length; col++)
                {
                    jaggedArray[row][col] = rowData[col];
                }
            }
            for (int row = 0; row < jaggedArray.GetLength(0) - 1; row++)
            {

                if (jaggedArray[row].GetLength(0) == jaggedArray[row + 1].GetLength(0))
                {
                    jaggedArray[row] = jaggedArray[row].Select(x => x * 2).ToArray();
                    jaggedArray[row + 1] = jaggedArray[row + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedArray[row] = jaggedArray[row].Select(x => x / 2).ToArray();
                    jaggedArray[row + 1] = jaggedArray[row + 1].Select(x => x / 2).ToArray();
                }

            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] splitedCommand = command.Split();
                string action = splitedCommand[0];
                int currRow = int.Parse(splitedCommand[1]);
                int currCol = int.Parse(splitedCommand[2]);
                double value = double.Parse(splitedCommand[3]);
                if (action == "Add" && IsValideIndexes(jaggedArray, currRow, currCol))
                {
                    jaggedArray[currRow][currCol] += value;
                }
                else if (action == "Subtract" && IsValideIndexes(jaggedArray, currRow, currCol))
                {
                    jaggedArray[currRow][currCol] -= value;
                }
            }
            foreach (var item in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }

        private static bool IsValideIndexes(double[][] jaggedArray, int row, int col)
        {
            if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray.Length)
            {
                return true;
            }
            return false;
        }
    }
}
