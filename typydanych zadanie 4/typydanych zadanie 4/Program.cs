using System;

public enum Plec
{
    Mezczyzna,
    Kobieta
}

public struct Student
{
    public string Nazwisko;
    public int NrAlbumu;
    public float Ocena;
    public Plec Plec;

    public void WypelnijStudenta(string nazwisko, int nrAlbumu, float ocena, Plec plec)
    {
        Nazwisko = nazwisko;
        NrAlbumu = nrAlbumu;
        Ocena = Math.Max(2.0f, Math.Min(5.0f, ocena)); 
        Plec = plec;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine("Nazwisko: " + Nazwisko + ", Nr albumu: " + NrAlbumu + ", Ocena: " + Ocena + ", Płeć: " + Plec);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] grupa = new Student[5];

        grupa[0].WypelnijStudenta("Kowalski", 12345, 4.8f, Plec.Mezczyzna);
        grupa[1].WypelnijStudenta("Nowak", 23456, 3.5f, Plec.Kobieta);
        grupa[2].WypelnijStudenta("Wiśniewski", 34567, 5.5f, Plec.Mezczyzna);
        grupa[3].WypelnijStudenta("Kowalczyk", 45678, 2.3f, Plec.Kobieta);
        grupa[4].WypelnijStudenta("Lewandowski", 56789, 4.2f, Plec.Mezczyzna);

        Console.WriteLine("Grupa studentów:");
        foreach (var student in grupa)
        {
            student.WyswietlInformacje();
        }

        float srednia = ObliczSrednia(grupa);
        Console.WriteLine("Średnia ocen: " + srednia);
    }

    static float ObliczSrednia(Student[] grupa)
    {
        float suma = 0;
        foreach (var student in grupa)
        {
            suma += student.Ocena;
        }

        return suma / grupa.Length;
    }
}
