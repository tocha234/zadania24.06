using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 20;
        int primeDivisors = CountPrimeDivisors(n);
        Console.WriteLine("Liczba dzielników pierwszych: " + primeDivisors);
    }

    static int CountPrimeDivisors(int n)
    {
        if (n <= 5)
        {
            return 0;
        }

        int primeDivisors = 0;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0 && IsPrime(i))
            {
                primeDivisors++;
            }
        }

        return primeDivisors;
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
