class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Imie = "Jan";
        student.Nazwisko = "Kowalski";
        student.NumerIndeksu = 12345;
        student.Kierunek = "Informatyka";

        Console.WriteLine("Student: " + student.Imie + " " + student.Nazwisko);
        Console.WriteLine("Numer indeksu: " + student.NumerIndeksu);
        Console.WriteLine("Kierunek: " + student.Kierunek);

        Przedmiot przedmiot = new Przedmiot();
        przedmiot.Nazwa = "Programowanie";
        przedmiot.KodPrzedmiotu = 123456;
        przedmiot.ECTS = 5;
        przedmiot.Wykladowca = "dr inż. Anna Nowak";

        Console.WriteLine("Przedmiot: " + przedmiot.Nazwa);
        Console.WriteLine("Kod przedmiotu: " + przedmiot.KodPrzedmiotu);
        Console.WriteLine("ECTS: " + przedmiot.ECTS);
        Console.WriteLine("Wykładowca: " + przedmiot.Wykladowca);

        NauczycielAkademicki nauczyciel = new NauczycielAkademicki();
        nauczyciel.Imie = "Anna";
        nauczyciel.Nazwisko = "Nowak";
        nauczyciel.StopienNaukowy = "dr inż.";
        nauczyciel.Specjalizacja = "Informatyka";

        Console.WriteLine("Nauczyciel: " + nauczyciel.StopienNaukowy + " " + nauczyciel.Imie + " " + nauczyciel.Nazwisko);
        Console.WriteLine("Specjalizacja: " + nauczyciel.Specjalizacja);
    }
    public struct Student
    {
        public string Imie;
        public string Nazwisko;
        public int NumerIndeksu;
        public string Kierunek;
    }

    public struct Przedmiot
    {
        public string Nazwa;
        public int KodPrzedmiotu;
        public int ECTS;
        public string Wykladowca;
    }

    public struct NauczycielAkademicki
    {
        public string Imie;
        public string Nazwisko;
        public string StopienNaukowy;
        public string Specjalizacja;
    }

}
