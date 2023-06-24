using System;

class Program
{
    static void Main(string[] args)
    {
        double x1 = 2.5;
        double y1 = 3.8;
        double x2 = -1.3;
        double y2 = 7.2;

        double length = CalculateSegmentLength(x1, y1, x2, y2);
        Console.WriteLine("Długość odcinka: " + length);
    }

    static double CalculateSegmentLength(double x1, double y1, double x2, double y2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;

        double length = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        return length;
    }
}
