using System;
using System.Collections.Generic;
using System.Text;

namespace PD220115
{
    class Osoba
    {
        public string Imie;
        public string Nazwisko;

        public Osoba()
        {
            Imie = "Imie";
            Nazwisko = "Nazwisko";
        }

        public Osoba(string imie, string nazwisko)
        {
            Imie = imie ?? throw new ArgumentNullException(nameof(imie));
            Nazwisko = nazwisko ?? throw new ArgumentNullException(nameof(nazwisko));
        }

        public virtual void WypiszInfo()
        {
            Console.WriteLine($"Osoba: {Imie} {Nazwisko}");
        }
    }
}
