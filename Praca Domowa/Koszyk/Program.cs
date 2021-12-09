using System;
using System.Collections.Generic;

namespace koszyk
{
    class Program
    {
        public static Produkt WybierzProdukt(List<Produkt> listaP)
        {
            int number;
            string input;
            System.Console.Write("\nPodaj nr produktu: ");
            input = System.Console.ReadLine();

            while (true)
            {
                if (int.TryParse(input, out number))
                {
                    if (number >= listaP.Count + 1 || number <= 0)
                    {
                        Console.WriteLine("Brak produktu, podaj jeszcze raz: ");
                        input = System.Console.ReadLine();
                    } 
                    else
                        break;
                }                    
                else
                {
                    System.Console.WriteLine(
                    "Podałeś nie poprawną liczbę.");
                    //Console.Clear();
                    System.Console.Write("Wprowadź liczbę jeszcze raz: ");
                    input = System.Console.ReadLine();
                }
            }

            Console.WriteLine($"===> {listaP[number - 1].nazwa} <===");
            return listaP[number - 1];
        }

        public static int PodajIlosc()
        {
            int number;
            string input;
            System.Console.Write("Podaj ilosc: ");
            input = System.Console.ReadLine();

            while (true)
            {
                if (int.TryParse(input, out number))
                     break;                
                else
                {
                    System.Console.WriteLine(
                    "Podałeś nie poprawną liczbę.");
                    //Console.Clear();
                    System.Console.Write("Wprowadź liczbę jeszcze raz: ");
                    input = System.Console.ReadLine();
                }
            }
            return number;
        }
        static void Main(string[] args)
        {
            Koszyk koszyk = new Koszyk();

            List<Produkt> listaProduktow = new List<Produkt>()
            {
                new Produkt("Mleko 3.2%", 2.99),
                new Produkt("Mleko 2%", 3.2),
                new Produkt("Mleko 0%", 3.5),
                new Produkt("Jogurt waniliowy", 1.29),
                new Produkt("Jogurt truskawkowy", 1.39),
                new Produkt("Jogurt morelowy", 1.29),
                new Produkt("Śmietana 12%", 1.99),
                new Produkt("Śmietana 30%", 2.99),
                new Produkt("Chleb zwykły", 2.99),
                new Produkt("Chleb razowy", 3.99),
                new Produkt("Bułka grahamka", 0.99),
                new Produkt("Bułka zwykła", 1.19),
                new Produkt("Jabłko LOBO", 2.49),
                new Produkt("Jabłko GLOSTER", 2.99),
                new Produkt("Pomidor", 5.5),
                new Produkt("Cebula", 0.99),
                new Produkt("Ziemniaki", 2.1),
                new Produkt("Jajka", 0.99),
                new Produkt("Mąka luksusowa 1 kg", 2.4),
                new Produkt("Mąka ziemniaczana 1 kg", 2.9),
                new Produkt("Woda gazowana 1 l", 2.2),
                new Produkt("Woda gazowana 0,5 l", 1.7),
                new Produkt("Woda niegazowana 1 l", 2.2),
                new Produkt("Woda niegazowana 0,5 l", 1.7),
                new Produkt("Coca-Cola 0,5 l", 4.5),
                new Produkt("Coca-Cola 1 l", 5.99),
                new Produkt("Fanta 0,5 l", 4.3),
                new Produkt("Fanta 2 l", 5.99),
                new Produkt("Masło roślinne", 3.99),
                new Produkt("Olej roślinny 1 l", 6.99)
            };

            while(true)
            {
                Console.Clear();

                Console.WriteLine("Dostępne produkty: ");
                Console.WriteLine("----------------------------------------------------------------------------------------------");
                //Console.WriteLine($"{listaProduktow[1].nazwa}");
                for (int i = 0; i < listaProduktow.Count; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine();
                    Console.Write($"[{i + 1,2}] {listaProduktow[i].nazwa,-25} {listaProduktow[i].cena,4:C2}            ");
                }

                Console.WriteLine("\n\n----------------------------------------------------------------------------------------------");

                koszyk.PokazKoszyk();

                Console.WriteLine("\n\n------- OPCJE --------");
                Console.WriteLine("[d] - Dodaj produkt");
                Console.WriteLine("[u] - Usuń produkt");
                Console.WriteLine("[p] - Podsumowanie");
                Console.WriteLine("[w] - Wyczyść koszyk");
                Console.WriteLine("[e] - Wyjście");

                Console.Write("\nWybór: ");

                ConsoleKeyInfo klawisz = Console.ReadKey();

                switch (klawisz.Key)
                {
                    case ConsoleKey.D:
                        //Console.Clear();
                        Produkt tmp = WybierzProdukt(listaProduktow);
                        koszyk.DodajProdukt(tmp, PodajIlosc());
                        break;

                    case ConsoleKey.U:
                        koszyk.UsunProdukt();
                        break;

                    case ConsoleKey.P:
                        Console.Clear();
                        koszyk.ZakonczZakup();
                        
                        break;

                    case ConsoleKey.W:
                        koszyk.WyczyscKoszyk();
                        break;

                    case ConsoleKey.Escape:
                    case ConsoleKey.E:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("\nBłedny wybór. Nacisnij dowolny klawisz...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
