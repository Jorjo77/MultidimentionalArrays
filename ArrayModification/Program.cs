using System;
using System.Linq;
using System.Threading;

namespace ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];
            for (int row = 0; row < matrix.Length; row++)
            {
                int[] rowData = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse).ToArray();
                matrix[row] = new int[rowData.Length];
                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }
            string command = Console.ReadLine();
            while (command!="END")
            {
                string[] splittedCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = splittedCommand[0];
                int row = int.Parse(splittedCommand[1]);
                int col = int.Parse(splittedCommand[2]);
                int value = int.Parse(splittedCommand[3]);
                bool IsInvalid = false;
                if (matrix.Length<=row||row<0)
                {
                    IsInvalid = true;
                }
                else if (matrix[row].Length<=col||col<0)
                {
                    IsInvalid = true;
                }
                if (IsInvalid)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (action=="Add")
                    {
                        matrix[row][col] += value;
                    }
                    if (action == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
