using System;

namespace Zadania_ps
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // ZADANIE 3.1
            // Napisz program, który sprawdza, czy podany rok jest rokiem przestępnym. Rok
            // przestępny dzieli się bez reszty przez 4, nie dzieli się przez 100
            // (za wyjątkiem lat podzielnych przez 400)

            Console.WriteLine("================ ZADANIE 3.1 ================\n");

            int rok;

            Console.Write("Podaj rok: ");
            rok = int.Parse(Console.ReadLine());

            if ((rok % 4 == 0 && rok % 100 != 0) || (rok % 400 ==0))
                Console.WriteLine("Rok przestępny");
            else
                Console.WriteLine("Rok nieprzestępny");

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 3.2
            // Napisz program pobierający od użytkownika dwie liczby całkowite.
            // Program powinien wyświetlać informację, czy druga liczba jest dzielnikiem pierwszej

            Console.WriteLine("\n\n================ ZADANIE 3.2 ================\n");
            
            int a, b;

            Console.Write("Podaj a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj b: ");
            b = int.Parse(Console.ReadLine());

            if (a % b == 0)
                Console.WriteLine("Liczba {0} jest dzielnikiem liczby {1}", b, a);
            else
                Console.WriteLine("Liczba {0} nie jest dzielnikiem liczby {1}", b, a);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 3.3
            // Napisz program pobierający od użytkownika 3 liczby.
            // Program ma wyświetlić wartość największej z nich.

            Console.WriteLine("\n\n================ ZADANIE 3.3 ================\n");

            int a_3, b_3, c_3;
            int najwiek = 0;
            Console.Write("Podaj a: ");
            a_3 = int.Parse(Console.ReadLine());
            Console.Write("Podaj b: ");
            b_3 = int.Parse(Console.ReadLine());
            Console.Write("Podaj c: ");
            c_3 = int.Parse(Console.ReadLine());

            if ((a_3 > b_3) && (a_3 > c_3))
                najwiek = a_3;

            if ((b_3 > a_3) && (b_3 > c_3))
                najwiek = b_3;

            if ((c_3 > a_3) && (c_3 > b_3))
                najwiek = c_3;

            Console.WriteLine("Największa liczba to {0}", najwiek);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 3.4
            // Napisz program – prosty kalkulator, który wczytuje od użytkownika wartości dwóch
            // zmiennych typu double oraz znak operacji(+lub – lub* lub /), a następnie wyświetla wynik
            // operacji dla podanych wartości. Przykładowo użytkownik wprowadził znak „+” i liczby 1,5
            // oraz 2,5, program powinien wyświetlić sumę obu liczb, czyli 4,0.

            Console.WriteLine("\n\n================ ZADANIE 3.4 ================\n");
            
            double p, d;
            double wynik = 0;
            char dzialanie;

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
                    break;

                case '-':
                    wynik = p - d;
                    break;

                case '*':
                    wynik = p * d;
                    break;

                case '/':
                    while (d == 0)
                    { 
                        Console.WriteLine("Nie można dzielić przez zero");
                        Console.Write("Podaj drugą liczbę jeszcze raz: ");
                        d = double.Parse(Console.ReadLine());
                    }
                    wynik = p / d;
                    break;

                default:
                    Console.WriteLine("Niepoprawny wybór");
                    break;
            }

            Console.WriteLine("WYNIK: {0}{1}{2} = {3}", p, dzialanie, d, wynik);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 3.5
            // Napisz program obliczający liczbę pierwiastków równania kwadratowego. Program ma
            // prosić użytkownika o podanie współczynników równania, a następnie ma wyświetlić
            // stosowny komunikat.

            Console.WriteLine("\n\n================ ZADANIE 3.5 ================\n");
            
            double a_5, b_5, c_5;
            double delta = 0;
            double x1 = 0, x2 = 0;

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

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 3.6
            // Napisz program, który oblicza wskaźnik masy ciała BMI. Program ma prosić
            // użytkownika o podanie wagi w kg oraz wzrostu w metrach

            Console.WriteLine("\n\n================ ZADANIE 3.6 ================\n");

            double wzrost, waga, bmi = 0;

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

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 3.7
            // Wykonaj program z przykładu 3.8 (str. 63)
            // z użyciem instrukcji switch..case (zamiast if..else)

            Console.WriteLine("\n\n================ ZADANIE 3.7 ================\n");

            Console.Write("Podaj nr dnia tygodnia: ");
            string numer = Console.ReadLine();

            switch (numer)
            {
                case "1":
                    Console.WriteLine("Poniedziałek");
                    break;
                case "2":
                    Console.WriteLine("Wtorek");
                    break;
                case "3":
                    Console.WriteLine("Środa");
                    break;
                case "4":
                    Console.WriteLine("Czwartek");
                    break;
                case "5":
                    Console.WriteLine("Piątek");
                    break;
                case "6":
                    Console.WriteLine("Sobota");
                    break;
                case "7":
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nieznany dzień tygodnia :(");
                    break;
            }

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 3.8
            // Pobierz od użytkownika wartość średniej ocen.
            // Program ma wyświetlać informacje o wysokości przysługującego stypendium
            // zgodnie z poniższą tabelą:
            //  Od Do
            // 2,00 3,99    0,00 zł
            // 4,00 4,79    350,00 zł
            // 4,80 5,00    550,00 zł

            Console.WriteLine("\n\n================ ZADANIE 3.8 ================\n");

            double srednia;
            double kwota = 0;

            Console.Write("Podaj średnią: ");
            srednia = double.Parse(Console.ReadLine());

            if (srednia <= 3.99)
                kwota = 0;
            else if (srednia <= 4.79)
                kwota = 350;
            else if (srednia <= 5.00)
                kwota = 550;
            else
                Console.WriteLine("Błędna wartość średniej");

            Console.WriteLine("Kwota stypendium: {0, -4:C2}", kwota);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 3.9
            // Gwiadki

            Console.WriteLine("\n\n================ ZADANIE 3.9 ================\n");

            int ile;

            Console.WriteLine("Podaj liczbę wierszy: ");
            ile = int.Parse(Console.ReadLine());

            // wariant a

            Console.WriteLine("Wariant a:");

            for (int w = 0; w < ile; w++)
            {
                for (int j = 0; j <= w; j++)
                    Console.Write("*");

                Console.WriteLine();
            }

            // wariant b
            Console.WriteLine("Wariant b:");

            for (int w = 0; w < ile; w++)
            {
                for (int j = ile - w; j > 0; j--)
                    Console.Write("*");

                Console.WriteLine();
            }

            // wariant c
            Console.WriteLine("Wariant c:");

            for (int c = 0; c < ile; c++)
            {
                for (int j = 1; j <= ile; j++)
                {
                    if (j < ile - c)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }                 

                Console.WriteLine();
            }

            // wariant d
            Console.WriteLine("Wariant d:");

            for (int w = 0; w < ile; w++)
            {
                for (int j = 0; j < ile; j++)
                {
                    if (w == 0 || w == ile-1)
                        Console.Write("*");
                    else
                    {
                        if (j == 0 || j == ile - 1)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                       
                }

                Console.WriteLine();
            }

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 3.10
            // Napisz program obliczający n! (n silnia), gdzie n jest podane przez użytkownika.

            Console.WriteLine("\n\n================ ZADANIE 3.10 ================\n");

            int i = 1;
            long silnia = 1;
            int ile_s;

            Console.Write("Podaj n silnie: ");
            ile_s = int.Parse(Console.ReadLine());

            while (i <= ile_s)
            {
                silnia = silnia * i;
                i++;
            }

            Console.WriteLine("{0}! = {1}", ile_s, silnia);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 3.11
            // Napisz program obliczający ile kolejnych liczb całkowitych
            // (rozpoczynając od wartości 1 należy dodać do siebie, aby suma przekroczyła wartość 100.

            Console.WriteLine("\n\n================ ZADANIE 3.11 ================\n");

            int suma_l = 0, licznik = 1;

            while (suma_l < 100)
            {
                
                Console.Write("{0}", licznik);
                suma_l += licznik;

                if (suma_l > 100)
                {
                    Console.Write("=100");
                    break;
                }
                Console.Write("+");
                licznik++;
            }

            Console.WriteLine("\nCzyli potrzebne było {0} liczb", licznik);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 3.12
            // Napisz program pobierający od użytkownika liczby całkowite.
            // Program ma pobierać te liczby do czasu, gdy użytkownik
            // wprowadzi wartość 0(zero).
            // Wynikiem działania programu ma być informacja o sumie
            // wprowadzonych przez użytkownika liczb.

            Console.WriteLine("\n\n================ ZADANIE 3.12 ================\n");

            int suma_u = 0;
            int licznik_u = 0;
            int tmp;

            Console.Write("Podaj pierwszą liczbę, 0 kończy wprowadzanie: ");
            tmp = int.Parse(Console.ReadLine());

            while (tmp != 0)
            {
                suma_u += tmp;
                licznik_u++;

                Console.Write("\nPodaj kolejną liczbę: ");
                tmp = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nWprowadziłeś {0} liczb, a ich suma równa się {1}", licznik_u, suma_u);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 3.13
            // Szereg naprzemienny (-1)^(n+1) * an

            Console.WriteLine("\n\n================ ZADANIE 3.13 ================\n");

            int ile_w;
            double Sn = 0;

            Console.WriteLine("---- Szereg (-1)^n*an ----");
            Console.Write("Podaj liczbę wyrazów: ");
            ile_w = int.Parse(Console.ReadLine());

            for (int an = 1; an <= ile_w; an++)
            {
                Sn += Math.Pow(-1, an + 1) * an;
                Console.WriteLine("an = {0}, Sn = {1}", an, Sn);

            }

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 3.14
            // Liczba N jest doskonała, gdy jest równa sumie swych podzielników mniejszych
            // od niej samej np. 6 = 1 + 2 + 3 = 6 – jest liczbą doskonałą.
            // Napisz program znajdujący liczby doskonałe w przedziale < 1,n >, gdzie n podaje użytkownik.

            Console.WriteLine("\n\n================ ZADANIE 3.14 ================\n");

            int suma_d = 0;
            int n;

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


            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 3.15
            // Dysponując monetami 1 zł, 2 zł, 5 zł sprawdź, na ile różnych sposobów
            // można wypłacić 10 zł.
            // Napisz program, który wyświetli w oknie konsoli wszystkie możliwe kombinacje.

            Console.WriteLine("\n\n================ ZADANIE 3.15 ================\n");

            int suma = 0;
            int kwota_r = 10;

            int nominal_1 = 1;
            int nominal_2 = 2;
            int nominal_3 = 5;

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

            Console.Write("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}
