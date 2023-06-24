using System;

class Program
{
    static void Main()
    {
        int rozmiar;
        bool poprawnyRozmiar;

        do
        {
            Console.Write("Podaj rozmiar tablicy (liczba nieparzysta): ");
            string input = Console.ReadLine();

            poprawnyRozmiar = int.TryParse(input, out rozmiar);

            if (!poprawnyRozmiar || rozmiar <= 0 || rozmiar % 2 == 0)
            {
                Console.WriteLine("Podano niepoprawny rozmiar. Podaj dodatnią, nieparzystą liczbę całkowitą.");
            }

        } while (!poprawnyRozmiar || rozmiar <= 0 || rozmiar % 2 == 0);

        int[,] tablica = new int[rozmiar, rozmiar];

        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                tablica[i, j] = 0;
            }
        }

        int liczba = 1;

        int ruch = 1;
        int wiersz = rozmiar / 2;
        int kolumna = rozmiar / 2;

        while (liczba <= rozmiar * rozmiar)
        {
            tablica[wiersz, kolumna] = liczba;
            liczba++;

            if (ruch == 1)
            {
                wiersz--;
                kolumna++;

                if (wiersz < 0 || kolumna >= rozmiar)
                {
                    wiersz++;
                    kolumna--;
                    ruch = 2;
                }
            }
            else if (ruch == 2)
            {
                wiersz++;
                kolumna--;

                if (wiersz >= rozmiar || kolumna < 0)
                {
                    wiersz--;
                    kolumna++;
                    ruch = 1;
                }
            }
        }

        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j].ToString().PadLeft(2) + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
