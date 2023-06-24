using System;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers = { 2.5, 3.7, 1.2, 5.1, 4.9 };
        int size = numbers.Length;
        double average = CalculateRecursiveAverage(numbers, size);
        Console.WriteLine("Średnia arytmetyczna: " + average);
    }

    static double CalculateRecursiveAverage(double[] numbers, int size)
    {
        if (size == 0)
        {
            return 0.0;
        }

        double lastNumber = numbers[size - 1];
        double partialAverage = CalculateRecursiveAverage(numbers, size - 1);
        double currentAverage = (partialAverage * (size - 1) + lastNumber) / size;

        return currentAverage;
    }
}
