class Program
{
    static void Main(string[] args)
    {
        DniTygodnia dzien = DniTygodnia.Sroda;
        Console.WriteLine("Dzisiejszy dzień to: " + dzien);

        EtapyPrania etap = EtapyPrania.Pranie;
        Console.WriteLine("Aktualny etap prania: " + etap);

        Posilki posilek = Posilki.Obiad;
        Console.WriteLine("Czas na: " + posilek);

        BierkiSzachowe bierka = BierkiSzachowe.Wieza;
        Console.WriteLine("Wybrana bierka to: " + bierka);
    }
    public enum DniTygodnia
    {
        Poniedzialek,
        Wtorek,
        Sroda,
        Czwartek,
        Piatek,
        Sobota,
        Niedziela
    }

    public enum EtapyPrania
    {
        WkladaniePomocnicze,
        Sortowanie,
        WyborProgramu,
        DodawanieDetergentu,
        Pranie,
        Plyniecie,
        Piorowanie,
        PlynDoPiora,
        Suszenie,
        Skladanie
    }

    public enum Posilki
    {
        Sniadanie,
        DrugieSniadanie,
        Obiad,
        Podwieczorek,
        Kolacja
    }

    public enum BierkiSzachowe
    {
        Pion,
        Wieza,
        Skoczek,
        Goniec,
        Hetman,
        Krol
    }

}
