using System;
using System.Windows.Forms;


namespace PO_pracaDomowaGrupa2
{    
    class Program
    {
        static void Main(string[] args)
        {
            Konto osoba1 = new Konto("Jan Kowal", 1000);
            Konto osoba2 = new Konto("Janina Nowak", 0);
            Konto osoba3 = new Konto("Marian Kwiatek", 6000);
            Konto osoba4 = new Konto("Julian Wesoły", 0);

            Console.WriteLine("\n\nOsoba 1: Operacje na koncie: \n");
            osoba1.OperacjaNaRachunku("Właściciel", 1000, TypOperacji.BankomatWplata);
            osoba1.OperacjaNaRachunku("Właściciel", 500, TypOperacji.KartaPlatnosc);
            osoba1.OperacjaNaRachunku("Jan Nowak", 1200, TypOperacji.PrzelewZlecono);
            osoba1.OperacjaNaRachunku("Właściciel", 1200, TypOperacji.KasaWyplata);
            osoba1.OperacjaNaRachunku("Właściciel", 1500, TypOperacji.BankomatWplata);

            Console.WriteLine("\n\nGenerowanie wyciągu: \n");
            osoba1.GenerujWyciag();
            osoba1.WyswietlWyciag();

            Console.WriteLine("\n\nOsoba 2: Operacje na koncie: \n");
            osoba2.OperacjaNaRachunku("Właściciel", 2000, TypOperacji.KasaWplata);
            osoba2.OperacjaNaRachunku("Sklep ABC", 125.5m, TypOperacji.KartaPlatnosc);
            osoba2.OperacjaNaRachunku("Sklep 'Mechanik'", 250.75m, TypOperacji.KartaPlatnosc);

            Console.WriteLine("\n\nGenerowanie wyciągu: \n");
            osoba2.GenerujWyciag();
            osoba2.WyswietlWyciag();


            Console.WriteLine("\n\nOsoba 3: Operacje na koncie: \n");
            osoba3.OperacjaNaRachunku("Właściciel", 2500, TypOperacji.BankomatWplata);
            osoba3.OperacjaNaRachunku("Sklep RTV/AGD", 2700, TypOperacji.KartaPlatnosc);
            osoba3.OperacjaNaRachunku("Halina Nowak", 1200, TypOperacji.PrzelewZlecono);
            osoba3.OperacjaNaRachunku("Mariola Kwiatek", 1500, TypOperacji.PrzelewOtrzymano);
            osoba3.OperacjaNaRachunku("Właściciel", 2500, TypOperacji.KasaWyplata);
            Console.WriteLine("\n\nGenerowanie wyciągu: \n");
            osoba3.GenerujWyciag();
            osoba3.WyswietlWyciag();


            Console.WriteLine("\n\nOsoba 4: Operacje na koncie: \n");
            osoba4.OperacjaNaRachunku("Właściciel", 1200, TypOperacji.BankomatWyplata);
            Console.WriteLine("\n\nGenerowanie wyciągu: \n");
            osoba4.GenerujWyciag();
            osoba4.WyswietlWyciag();








        }
    }
}
