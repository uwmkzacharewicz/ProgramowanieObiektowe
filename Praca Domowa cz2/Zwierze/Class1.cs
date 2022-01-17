using System;
using System.Collections.Generic;
using System.Text;

namespace PO_pracaDomowaGrupa2
{
    public class Pies : Zwierze
    {
        string imie;
        int waga;
        int rozmiar;

        public override void JakSiePoruszam()
        {
            Console.WriteLine("Chodzę na czterech łapach (w domu)");
        }

        public override void CoJem()
        {
            Console.WriteLine("Wszystko co mi da mój właściciel");
        }
    }

    public class Wilk : Zwierze
    {
        string imie;
        int waga;
        int rozmiar;

        public override void JakSiePoruszam()
        {
            Console.WriteLine("Chodzę na czterech łapach (w lesie)");
        }

        public override void CoJem()
        {
            Console.WriteLine("Każdą ofiarę, która jest słabsza");
        }

    }

    public class Rekin : Zwierze
    {
        string imie;
        int waga;
        int rozmiar;

        public override void JakSiePoruszam()
        {
            Console.WriteLine("Pływam w wodzie");
        }

        public override void CoJem()
        {
            Console.WriteLine("Ludzi...");
        }

    }

    public class Orzel : Zwierze
    {
        string imie;
        int waga;
        int rozmiar;

        public override void JakSiePoruszam()
        {
            Console.WriteLine("Szybuje po niebie");
        }

        public override void CoJem()
        {
            Console.WriteLine("Myszy, a najlepiej gołębie...");
        }

    }

    public class Krokodyl : Zwierze
    {
        string imie;
        int waga;
        int rozmiar;

        public override void JakSiePoruszam()
        {
            Console.WriteLine("Pływam w wodzie i chodzę po brzegu");
        }

        public override void CoJem()
        {
            Console.WriteLine("Potrafię zjeść nawet lwa...");
        }
    }
}
