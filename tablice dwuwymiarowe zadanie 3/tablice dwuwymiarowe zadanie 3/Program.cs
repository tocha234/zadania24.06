using System;

class Program
{
    static void Main()
    {
        int rozmiar;
        bool poprawnyRozmiar;

        do
        {
            Console.Write("Podaj rozmiar tablicy: ");
            string input = Console.ReadLine();

            poprawnyRozmiar = int.TryParse(input, out rozmiar);

            if (!poprawnyRozmiar || rozmiar <= 0)
            {
                Console.WriteLine("Podano niepoprawny rozmiar. Podaj dodatnią liczbę całkowitą.");
            }

        } while (!poprawnyRozmiar || rozmiar <= 0);

        int[,] tablica = new int[rozmiar, rozmiar];
        int liczba = 1;

        for (int i = 0; i < tablica.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    tablica[i, j] = liczba;
                    liczba++;
                }
            }
            else
            {
                for (int j = tablica.GetLength(1) - 1; j >= 0; j--)
                {
                    tablica[i, j] = liczba;
                    liczba++;
                }
            }
        }

        for (int i = 0; i < tablica.GetLength(0); i++)
        {
            for (int j = 0; j < tablica.GetLength(1); j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
