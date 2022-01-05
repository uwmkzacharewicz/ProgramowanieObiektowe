using System;
using System.Collections.Generic;
using System.Text;

namespace PO_pracaDomowaGrupa2
{
    public class Osoba
    {
        protected private string Imie;
        protected private string Nazwisko;
        protected private int RokUrodzenia;

        private string _MiejsceZamieszkania;
        public string MiejsceZamieszkania
        {
            get { return _MiejsceZamieszkania; }
            set { _MiejsceZamieszkania = value; }
        }


        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }
        public Osoba(string imie, string nazwisko, int rokUrodzenia) : this(imie, nazwisko)
        {
            RokUrodzenia = rokUrodzenia;
        }

        public override string ToString()
        {
            return $"Osoba: {Imie} {Nazwisko}, rok urodzenia: {RokUrodzenia}";
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"Osoba: {Imie} {Nazwisko}, rok urodzenia: {RokUrodzenia}");
        }

        public void ObliczWiek()
        {
            Console.WriteLine("Tutaj licze twój wiek (public)");
        }

        protected void ObliczWiekProtected()
        {
            Console.WriteLine("Tutaj licze twój wiek (protected)");
        }

        public void ObliczWiekPrzezProtected()
        {
            // Protected działa tylko z poziomu danej klasy i pochodnych
            Console.WriteLine("Osoba: ");
            ObliczWiekProtected();
        }




    }
}
