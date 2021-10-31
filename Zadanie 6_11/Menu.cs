using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    static class Menu
    {
        static string[] pozycjeMenu = { "Pierwiastki równania kwadratowego",
                                        "BMI",
                                        "Tablica n-elementowa",
                                        "Rozmień pieniądze", 
                                        "Koniec"};
        static int aktywnaPozycjaMenu = 0;

        public static void StartMenu()
        {
            Console.Title = "Przykładowe programy";
            Console.CursorVisible = false;

            while(true)
            {
                PokazMenu();
                WybieranieOpcji();
                UruchomOpcje();
            }            
        }

        static void PokazMenu()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("------ PROGRAMY ------");
            Console.WriteLine();

            for(int i = 0; i < pozycjeMenu.Length; i++)
            {
                if (i == aktywnaPozycjaMenu)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0, -35}", pozycjeMenu[i]);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                    Console.WriteLine(pozycjeMenu[i]);
            }
        }

        static void WybieranieOpcji()
        {
            do
            {
                ConsoleKeyInfo klawisz = Console.ReadKey();

                if (klawisz.Key == ConsoleKey.UpArrow)
                {
                    if (aktywnaPozycjaMenu > 0)
                        aktywnaPozycjaMenu = aktywnaPozycjaMenu - 1;
                    else
                        aktywnaPozycjaMenu = 0;
                        //aktywnaPozycjaMenu = pozycjeMenu.Length - 1;
                    
                    PokazMenu();
                }
                else if (klawisz.Key == ConsoleKey.DownArrow)
                {
                    if (aktywnaPozycjaMenu < pozycjeMenu.Length - 1)
                        aktywnaPozycjaMenu = aktywnaPozycjaMenu + 1;
                    else
                        aktywnaPozycjaMenu = pozycjeMenu.Length - 1;
                    
                    //aktywnaPozycjaMenu = (aktywnaPozycjaMenu + 1) % pozycjeMenu.Length;
                    PokazMenu();
                }
                else if (klawisz.Key == ConsoleKey.Escape)
                {
                    aktywnaPozycjaMenu = pozycjeMenu.Length - 1;
                    break;
                }
                else if (klawisz.Key == ConsoleKey.Enter)
                    break;
            } while (true);

        }
        static void UruchomOpcje()
        {

            switch (aktywnaPozycjaMenu)
            {
                case 0:
                    Console.Clear();
                    pierwiastki_rownania();
                    break;

                case 1:
                    Console.Clear();
                    wylicz_BMI();
                    break;

                case 2:
                    Console.Clear();
                    tablica_nelem();
                    break;

                case 3:
                    Console.Clear();
                    komb_monet();
                    break;
                
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }

        static void pierwiastki_rownania()
        {
            Console.SetCursorPosition(12, 4);

            double a_5, b_5, c_5;
            double delta;
            double x1, x2;

            while (true)
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

        static void wylicz_BMI()
        {
            Console.SetCursorPosition(12, 4);
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

        static void tablica_nelem()
        {
            Console.SetCursorPosition(12, 4);

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

        static void komb_monet()
        {
            Console.SetCursorPosition(12, 4);

            int suma, kwota_r, nominal_1, nominal_2, nominal_3;

            while (true)
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
