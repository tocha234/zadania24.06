using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

        FindClosestRows(array, out int row1, out int row2);

        Console.WriteLine("Najbardziej zbliżone wiersze: " + row1 + ", " + row2);
    }

    static void FindClosestRows(int[,] array, out int row1, out int row2)
    {
        int numRows = array.GetLength(0);
        double minDifference = double.MaxValue;
        row1 = 0;
        row2 = 0;

        for (int i = 0; i < numRows - 1; i++)
        {
            for (int j = i + 1; j < numRows; j++)
            {
                double difference = CalculateRowDifference(array, i, j);

                if (difference < minDifference)
                {
                    minDifference = difference;
                    row1 = i;
                    row2 = j;
                }
            }
        }
    }

    static double CalculateRowDifference(int[,] array, int rowIndex1, int rowIndex2)
    {
        int numColumns = array.GetLength(1);
        double difference = 0;

        for (int k = 0; k < numColumns; k++)
        {
            int element1 = array[rowIndex1, k];
            int element2 = array[rowIndex2, k];
            difference += Math.Pow(element1 - element2, 2);
        }

        return difference;
    }
}
