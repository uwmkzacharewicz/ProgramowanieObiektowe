using System;

namespace PO_pracaDomowa1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba dyrektor = new Osoba();

            dyrektor.imie = "Jan";
            dyrektor.nazwisko = "Kowalski";
            dyrektor.rokUrodzenia = 1966;
            dyrektor.waga = 75;
            dyrektor.wzrost = 180;
            dyrektor.plec = Plec.M;
            dyrektor.okulary = true;
            dyrektor.PokazDane();
            Console.WriteLine($"{dyrektor.DodajPrzedrostek()} {dyrektor.imie} {dyrektor.nazwisko}, wiek {dyrektor.ObliczWiek()}, wzrost: {dyrektor.wzrost}");

            Osoba pacjent = new Osoba();
            pacjent.imie = "Henryk";
            pacjent.nazwisko = "Nowak";
            pacjent.rokUrodzenia = 1982;
            pacjent.waga = 120;
            pacjent.wzrost = 185;


            pacjent.WyliczBMI();



        }
    }
}
