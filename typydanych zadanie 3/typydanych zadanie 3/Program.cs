using System;

public enum KlasaRzadkosci
{
    Powszechny,
    Rzadki,
    Unikalny,
    Epicki
}

public enum TypPrzedmiotu
{
    Bron,
    Zbroja,
    Amulet,
    Pierscien,
    Helm,
    Tarcza,
    Buty
}

public struct Przedmiot
{
    public float Waga;
    public int Wartosc;
    public KlasaRzadkosci Rzadkosc;
    public TypPrzedmiotu Typ;
    public string NazwaWlasna;

    public void WypelnijPrzedmiot(float waga, int wartosc, KlasaRzadkosci rzadkosc, TypPrzedmiotu typ, string nazwaWlasna)
    {
        Waga = waga;
        Wartosc = wartosc;
        Rzadkosc = rzadkosc;
        Typ = typ;
        NazwaWlasna = nazwaWlasna;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine("Nazwa przedmiotu: " + NazwaWlasna);
        Console.WriteLine("Typ: " + Typ);
        Console.WriteLine("Klasa rzadkości: " + Rzadkosc);
        Console.WriteLine("Waga: " + Waga);
        Console.WriteLine("Wartość: " + Wartosc + " sztuk złota");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Przedmiot[] przedmioty = new Przedmiot[5];

        przedmioty[0].WypelnijPrzedmiot(2.5f, 50, KlasaRzadkosci.Powszechny, TypPrzedmiotu.Bron, "Miecz");
        przedmioty[1].WypelnijPrzedmiot(3.2f, 100, KlasaRzadkosci.Rzadki, TypPrzedmiotu.Zbroja, "Pancerz");
        przedmioty[2].WypelnijPrzedmiot(1.0f, 200, KlasaRzadkosci.Unikalny, TypPrzedmiotu.Amulet, "Amulet Mocy");
        przedmioty[3].WypelnijPrzedmiot(0.5f, 500, KlasaRzadkosci.Epicki, TypPrzedmiotu.Pierscien, "Pierścień Nieśmiertelności");
        przedmioty[4].WypelnijPrzedmiot(1.8f, 80, KlasaRzadkosci.Powszechny, TypPrzedmiotu.Helm, "Helm Rycerza");

        foreach (var przedmiot in przedmioty)
        {
            przedmiot.WyswietlInformacje();
        }

        Przedmiot losowyPrzedmiot = LosujPrzedmiot(przedmioty);

        Console.WriteLine("Losowo wybrany przedmiot:");
        losowyPrzedmiot.WyswietlInformacje();
    }

    static Przedmiot LosujPrzedmiot(Przedmiot[] przedmioty)
    {
        Random rand = new Random();
        KlasaRzadkosci[] dostepneRzadkosci = { KlasaRzadkosci.Powszechny, KlasaRzadkosci.Rzadki, KlasaRzadkosci.Unikalny, KlasaRzadkosci.Epicki };

        KlasaRzadkosci wylosowanaRzadkosc = dostepneRzadkosci[rand.Next(dostepneRzadkosci.Length)];

        int[] indeksy = new int[przedmioty.Length];
        int ilosc = 0;
        for (int i = 0; i < przedmioty.Length; i++)
        {
            if (przedmioty[i].Rzadkosc == wylosowanaRzadkosc)
            {
                indeksy[ilosc] = i;
                ilosc++;
            }
        }

        int wylosowanyIndeks = indeksy[rand.Next(ilosc)];

        return przedmioty[wylosowanyIndeks];
    }
}
