using System;
using System.Collections.Generic;
using System.Text;

namespace PO_pracaDomowa1_2
{
    enum Plec
    {
        K,
        M
    }

    // public, element klasy dostępny z wnętrza i spoza klasy
    // private, element dostępny tylko z wnętrza klasy, domyślny
    // protected, dostęp z wnętrza klasy i klas pochodnych
    // internal, dostęp klas z tego samego zestawu
    // protected internal, widoczna z wnętrza klasy, w której została zadeklarowana(lub pochodnej od niej) oraz z wnętrza zestawu
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary { get; set; }
        public Plec plec;

        public int ObliczWiek()
        {
            int aktualnyRok = DateTime.Now.Year;

            return aktualnyRok - rokUrodzenia;
        }

        public void PokazDane()
        {
            Console.WriteLine($"{this.DodajPrzedrostek()} {imie} {nazwisko}, waga: {waga}, wzrost: {wzrost}, płeć: {plec} ");
        }

        public string DodajPrzedrostek()
        {
            string _out = "";

            if (plec == Plec.K)
                _out += "Pani";
            else if (plec == Plec.M)
                _out += "Pan";
            else
                _out += "";

            return _out;
        }

        public void WyliczBMI()
        {
            double bmi = 0;
            double wzrostM = (double) this.wzrost / 100;

            Console.WriteLine($"Wzrost: {wzrostM}, waga: {waga}");

            //bmi = 1.0 * waga / (wzrost * wzrost);
            bmi = waga / (wzrostM * wzrostM);

            Console.WriteLine("Twoje BMI wynosi: {0,-4:F2}", bmi);
            Console.Write("KLASYFIKACJA: ", bmi);

            if (bmi < 16)
                Console.WriteLine("niedowaga: wygłodzenie");

            else if (bmi < 16.99)
                Console.WriteLine("niedowaga: wychudzenie");

            else if (bmi < 18.49)
                Console.WriteLine("niedowaga");

            else if (bmi < 24.99)
                Console.WriteLine("pożądana masa ciała");

            else if (bmi < 29.99)
                Console.WriteLine("nadwaga");

            else if (bmi < 34.99)
                Console.WriteLine("otyłość I stopnia");

            else if (bmi < 39.99)
                Console.WriteLine("otyłość II stopnia");

            else   // powyżej 40
                Console.WriteLine("otyłość III stopnia");           
        
        }
    }
    
    
}
