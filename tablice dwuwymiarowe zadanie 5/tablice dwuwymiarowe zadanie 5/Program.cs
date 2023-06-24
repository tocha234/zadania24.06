using System;

class Program
{
    static void Main()
    {
        int[,] magicznyKwadrat1 = {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 8 }
        };

        int[,] magicznyKwadrat2 = {
            { 16, 3, 2, 13 },
            { 5, 10, 11, 8 },
            { 9, 6, 7, 12 },
            { 4, 15, 14, 1 }
        };

        int[,] niespelniajacyUnikatowosci = {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 1 }
        };

        int[,] niespelniajacySum = {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 9 }
        };

        Console.WriteLine("1. Sprawdzanie magicznego kwadratu 1");
        SprawdzMagicznyKwadrat(magicznyKwadrat1);

        Console.WriteLine("\n2. Sprawdzanie magicznego kwadratu 2");
        SprawdzMagicznyKwadrat(magicznyKwadrat2);

        Console.WriteLine("\n3. Sprawdzanie kwadratu niespełniającego warunku unikatowości");
        SprawdzMagicznyKwadrat(niespelniajacyUnikatowosci);

        Console.WriteLine("\n4. Sprawdzanie kwadratu niespełniającego warunku sum");
        SprawdzMagicznyKwadrat(niespelniajacySum);

        Console.ReadKey();
    }

    static void SprawdzMagicznyKwadrat(int[,] kwadrat)
    {
        int rozmiar = kwadrat.GetLength(0);
        int sumaOczekiwana = 0;

        for (int i = 0; i < rozmiar; i++)
        {
            int sumaWiersza = 0;
            for (int j = 0; j < rozmiar; j++)
            {
                sumaWiersza += kwadrat[i, j];
            }

            if (i == 0)
            {
                sumaOczekiwana = sumaWiersza;
            }
            else if (sumaWiersza != sumaOczekiwana)
            {
                Console.WriteLine("Kwadrat nie jest magiczny");
                return;
            }
        }

        for (int j = 0; j < rozmiar; j++)
        {
            int sumaKolumny = 0;
            for (int i = 0; i < rozmiar; i++)
            {
                sumaKolumny += kwadrat[i, j];
            }

            if (sumaKolumny != sumaOczekiwana)
            {
                Console.WriteLine("Kwadrat nie jest magiczny");
                return;
            }
        }

        int sumaGlownaPrzekatna = 0;
        for (int i = 0; i < rozmiar; i++)
        {
            sumaGlownaPrzekatna += kwadrat[i, i];
        }

        if (sumaGlownaPrzekatna != sumaOczekiwana)
        {
            Console.WriteLine("Kwadrat nie jest magiczny");
            return;
        }

        int sumaDrugaPrzekatna = 0;
        for (int i = 0; i < rozmiar; i++)
        {
            sumaDrugaPrzekatna += kwadrat[i, rozmiar - i - 1];
        }

        if (sumaDrugaPrzekatna != sumaOczekiwana)
        {
            Console.WriteLine("Kwadrat nie jest magiczny");
            return;
        }

        Console.WriteLine("Kwadrat jest magiczny");
    }
}
