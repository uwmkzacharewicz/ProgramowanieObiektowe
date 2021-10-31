using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    static class MojeMenu
    {
        public static void StartMojeMenu()
        {
            Console.Title = "Menu";

            while(true)
            {
                Console.Clear();
                Console.WriteLine("---- MENU ----");
                Console.WriteLine("1 - Kalkulator");
                Console.WriteLine("2 - Pierwiastki równania kwadratowego");
                Console.WriteLine("3 - Liczby doskonałe");
                Console.WriteLine("4 - BMI");
                Console.WriteLine("5 - Rozmień pieniądze :)");
                Console.WriteLine("6 - Tablica n-elementowa");
                Console.WriteLine("e - Koniec");

                Console.Write("\nWybór: ");

                ConsoleKeyInfo klawisz = Console.ReadKey();

                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        kalkulator();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        pierwiastki_rownania();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        liczba_doskonala();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        wylicz_BMI();
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear();
                        komb_monet();
                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Console.Clear();
                        tablica_nelem();
                        break;

                    case ConsoleKey.Escape:
                    case ConsoleKey.E:
                        Environment.Exit(0);
                        break;
                    
                    default:
                        break;

                }
            }
        }

        static void opcjaWBudowie()
        {
            Console.WriteLine("Opcja w budowie");
            Console.ReadKey(); 
        }

        static void kalkulator()
        {
            double p, d;
            double wynik = 0;
            char dzialanie;
            bool poprawny = false;

            while(true)
            {
                Console.Clear();

                Console.Write("Podaj pierwszą liczbę: ");
                p = double.Parse(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                d = double.Parse(Console.ReadLine());

                Console.WriteLine("Jakie działanie chcesz wykonać? ");
                Console.WriteLine("[+] dodawanie         [-] odejmowanie");
                Console.WriteLine("[*] mnożenie          [/] dzielenie");
                Console.Write("WYBÓR: ");

                dzialanie = char.Parse(Console.ReadLine());

                switch (dzialanie)
                {
                    case '+':
                        wynik = p + d;
                        poprawny = true;
                        break;

                    case '-':
                        wynik = p - d;
                        poprawny = true;
                        break;

                    case '*':
                        wynik = p * d;
                        poprawny = true;
                        break;

                    case '/':
                        while (d == 0)
                        {
                            Console.WriteLine("Nie można dzielić przez zero");
                            Console.Write("Podaj drugą liczbę jeszcze raz: ");
                            d = double.Parse(Console.ReadLine());
                        }
                        wynik = p / d;
                        poprawny = true;
                        break;

                    default:
                        Console.WriteLine("Niepoprawny wybór");
                        poprawny = false;
                        break;
                        
                }

                if (poprawny)
                    Console.WriteLine("WYNIK: {0}{1}{2} = {3}", p, dzialanie, d, wynik);
                
                Console.Write("Spróbuj ponownie [p] lub wyjdź [e]: ");

                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.P)
                    continue;
                else if (klawisz.Key == ConsoleKey.E)
                    break;
                else
                    continue;

            }
        }

        static void pierwiastki_rownania()
        {
            double a_5, b_5, c_5;
            double delta;
            double x1, x2;

            while(true)
            {
                Console.Clear();

                x1 = x2 = delta = 0;

                Console.Write("Podaj współczynnik a: ");
                a_5 = double.Parse(Console.ReadLine());
                Console.Write("Podaj współczynnik b: ");
                b_5 = double.Parse(Console.ReadLine());
                Console.Write("Podaj współczynnik c: ");
                c_5 = double.Parse(Console.ReadLine());

                Console.WriteLine("f(x) = {0}x^2 + {1}x + {2}", a_5, b_5, c_5);

                // obliczenie delty
                delta = (b_5 * b_5) - (4 * a_5 * c_5);

                if (delta > 0)          // jezeli delta > 0 to dwa rozwiazania
                {
                    x1 = (-b_5 - Math.Sqrt(delta)) / (2 * a_5);
                    x2 = (-b_5 + Math.Sqrt(delta)) / (2 * a_5);
                    Console.WriteLine("Dwa rozwiązania: x1 = {0,-4:G2} i x2 = {1,-4:G2}", x1, x2);
                }

                else if (delta == 0)    // jeżeli delta = 0 to jedno rozwiazanie
                {
                    x1 = -b_5 / (2 * a_5);
                    Console.WriteLine("Jedno rozwiązanie: x = {0,-4:G2}", x1);
                }

                else                    // jezeli delta < 0 to brak rozwiazan
                    Console.WriteLine("Brak rozwiązań równania");


                Console.Write("Spróbuj ponownie [p] lub wyjdź [e]: ");
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.P)
                    continue;
                else if (klawisz.Key == ConsoleKey.E)
                    break;
                else
                    continue;

            }           
        }

        static void wylicz_BMI()
        {
            double wzrost, waga, bmi;

            while (true)
            {
                Console.Clear();

                bmi = 0;

                Console.Write("Podaj swój wzrost w m: ");
                wzrost = double.Parse(Console.ReadLine());
                Console.Write("Podaj swoją wagę w kg: ");
                waga = double.Parse(Console.ReadLine());

                bmi = waga / (wzrost * wzrost);

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

                Console.Write("Spróbuj ponownie [p] lub wyjdź [e]: ");
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.P)
                    continue;
                else if (klawisz.Key == ConsoleKey.E)
                    break;
                else
                    continue;
            }
        }

        static void liczba_doskonala()
        {
            int suma_d, n;

            while(true)
            {
                suma_d = 0;               

                Console.Write("Podaj koniec przedziału: ");
                n = int.Parse(Console.ReadLine());

                Console.Write("Liczby doskonałe w przedziale (1,{0}): ", n);

                for (int liczba = 1; liczba <= n; liczba++)
                {
                    suma_d = 0;


                    for (int dzielnik = 1; dzielnik <= liczba / 2; dzielnik++)
                    {
                        if (liczba % dzielnik == 0)
                            suma_d += dzielnik;
                    }

                    if (suma_d == liczba)
                        Console.Write("{0} ", liczba);
                }

                Console.Write("\nSpróbuj ponownie [p] lub wyjdź [e]: ");
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.P)
                    continue;
                else if (klawisz.Key == ConsoleKey.E)
                    break;
                else
                    continue;
            }

        }

        static void komb_monet()
        {
            int suma, kwota_r, nominal_1, nominal_2, nominal_3;

            while(true)
            {
                Console.Clear();

                suma = 0;

                Console.WriteLine("Podaj kwotę do rozmienienia i 3 nominały: ");
                Console.Write("kwota: ");
                kwota_r = int.Parse(Console.ReadLine());
                Console.Write("nominał 1: ");
                nominal_1 = int.Parse(Console.ReadLine());
                Console.Write("nominał 2: ");
                nominal_2 = int.Parse(Console.ReadLine());
                Console.Write("nominał 3: ");
                nominal_3 = int.Parse(Console.ReadLine());


                Console.WriteLine("+----------------------------------------------------------+");
                Console.WriteLine("|{0,28} zł                           |", kwota_r);
                Console.WriteLine("+------------------+------------------+--------------------+");
                Console.WriteLine("|   {0,5} zł       |   {1,5} zł       |    {2,5} zł        |", nominal_1, nominal_2, nominal_3);
                Console.WriteLine("+------------------+------------------+--------------------+");

                for (int m1 = 0; m1 <= kwota_r; m1 += nominal_1)
                {
                    for (int m2 = 0; m2 <= kwota_r; m2 += nominal_2)
                    {
                        for (int m3 = 0; m3 <= kwota_r; m3 += nominal_3)
                        {
                            suma = m1 + m2 + m3;
                            if (suma == kwota_r)
                                Console.WriteLine("|{0,4} szt ({1,2} zł)  |{2,4} szt ({3,2} zł)  | {4,4} szt ({5,2} zł)   |", m1 / nominal_1, m1, m2 / nominal_2, m2, m3 / nominal_3, m3);
                        }
                    }
                }

                Console.WriteLine("+------------------+------------------+--------------------+");

                Console.Write("Spróbuj ponownie [p] lub wyjdź [e]: ");
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.P)
                    continue;
                else if (klawisz.Key == ConsoleKey.E)
                    break;
                else
                    continue;

            }          
        }

        static void tablica_nelem()
        {
            int rozmiar3;
            int w_max, i_max;
            int w_min, i_min;
            int dodatnie;
            double suma, srednia;

            while (true)
            {
                Console.Clear();

                suma = 0; srednia = 0;
                dodatnie = 0;

                Console.Write("Podaj rozmiar tablicy: ");
                rozmiar3 = int.Parse(Console.ReadLine());

                int[] tab_3 = new int[rozmiar3];

                Console.Write("Dane ręcznie wprowadzane [w] czy losowe [dowolny klawisz]: ");

                ConsoleKeyInfo klawisz_r = Console.ReadKey();

                if (klawisz_r.Key == ConsoleKey.W)
                {
                    Console.Write("\nPodaj wartości: ");
                    for (int i = 0; i < rozmiar3; i++)
                    {
                        Console.Write("[{0}]: ", i + 1);
                        tab_3[i] = int.Parse(Console.ReadLine());
                    }

                }
               // else if (klawisz_r.Key == ConsoleKey.W)
                else
                {
                    Random rand = new Random();
                    for (int i = 0; i < rozmiar3; i++)
                        tab_3[i] = rand.Next(-100, 100);
                }

                Console.WriteLine("\n\nTwoja tablica: ");
                foreach (int x in tab_3)
                    Console.Write("{0} ", x);

                i_max = i_min = 0;
                w_max = w_min = tab_3[0];

                for (int i = 0; i < rozmiar3; i++)
                {
                    if (tab_3[i] > w_max)
                    {
                        w_max = tab_3[i];
                        i_max = i;
                    }

                    if (tab_3[i] < w_min)
                    {
                        w_min = tab_3[i];
                        i_min = i;
                    }

                    if (tab_3[i] > 0)
                        dodatnie++;

                    suma += tab_3[i];
                }

                srednia = suma / rozmiar3;

                Console.WriteLine("\n\nPODSUMOWANIE:");
                Console.WriteLine("Wartosc MAX: [{0}] {1}", i_max, w_max);
                Console.WriteLine("Wartosc MIN: [{0}] {1}", i_min, w_min);
                Console.WriteLine("Liczba dodatnich elementów: {0}", dodatnie);
                Console.WriteLine("SUMA: {0}", suma);
                Console.WriteLine("ŚREDNIA: {0, 2:F2}", srednia);

                Console.Write("\nSpróbuj ponownie [p] lub wyjdź [e]: ");
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.P)
                    continue;
                else if (klawisz.Key == ConsoleKey.E)
                    break;
                else
                    continue;

            }

        }
    }
}
