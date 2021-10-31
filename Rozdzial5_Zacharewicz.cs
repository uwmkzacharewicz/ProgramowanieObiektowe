using System;

namespace Zadania_ps
{
    class Program
    {
        static double zamien_na_C(double F)   // ZADANIE 1
        {
            return (F - 32) * 0.5556;
        }

        static bool sprawdz_ab(double n, double m, double z) // ZADANIE 2
        {
            if (z > n && z < m)
                return true;
            else
                return false;
        }

        // ZADANIE 3
        static void Przesun(ref double a, ref double b, double c, double d)
        {
            a += c;
            b += d;
        }

        // ZADANIE 4A
        static int[] skalar_mnoz_A(int[] tablica, int rozmiar, int mnoznik)
        {
            int[] tab = new int[rozmiar];

            for (int i = 0; i < rozmiar; i++)
                tab[i] = tablica[i] * mnoznik;

            return tab;
        }

        // ZADANIE 4B
        static void skalar_mnoz_B(int[] tab, int mnoznik)
        {
            for (int i = 0; i < tab.Length; i++)
                tab[i] = tab[i] * mnoznik;
        }

        // ZADANIE 5
        static void Rysuj(int dlugosc, int szerokosc, char znak)
        {
            for (int i = 0; i < szerokosc; i++)
            {
                for (int j = 0; j < dlugosc; j++)
                {
                    Console.Write(znak);
                }
                Console.WriteLine();
            }
        }

        // ZADANIE 6
        static void mnoz_lancuch(string[] tab, int mnoznik)
        {
            string tmp = String.Empty;

            for (int idx = 0; idx < tab.Length; idx++)
            {
                tmp = tab[idx];

                for (int m = 1; m < mnoznik; m++)
                    tab[idx] = string.Concat(tab[idx], tmp);
            }
        }

        // ZADANIE 7
        static int W_x_iter(int x, int n)
        {
            int wynik = 0;

            for (int i = 1; i <= n; i++)
                wynik += x + i;

            return wynik;
        }

        static int W_x_rek(int x, int n)
        {
            if (n == 0)
                return 0;
            else
                return W_x_rek(x, n - 1) + (x + n);
        }

        // ZADANIE 8
        static int Suma_cyfr(int x)
        {
            string tmp = String.Empty;
            int suma = 0;

            tmp = Convert.ToString(x);

            for (int i = 0; i < tmp.Length; i++)
                suma += int.Parse(tmp[i].ToString());

            return suma;
        }

        // ZADANIE 9
        static int CiagFin_r(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return CiagFin_r(n - 1) + CiagFin_r(n - 2);
        }

        static int CiagFin_i(int n)
        {
            int x, y;

            if (n == 0)
                return 0;

            // ustawienia poczatkowe ciagu
            x = 0;
            y = 1;

            for (int i = 1; i < n; i++)
            {
                if (i == 1 || i == 2)
                    y = 1;

                y += x;
                x = y - x;
            }
            return y;
        }

        // ZADANIE 10
        static int Oblicz(int n)
        {
            if (n <= 1)
                return 1;
            else
                return (n + Oblicz(n - 1));
        }

        static void Main(string[] args)
        {
            
            // ZADANIE 5.1
            // Napisz program zawierający metodę statyczną obliczającą temperaturę w stopniach
            // Fahrenheita na temperaturę w stopniach Celsjusza. Metoda ma przyjmować jeden argument
            // (temperaturę w stopniach Fahrenheita) i zwracać temperaturę w stopniach Celsjusza

            Console.WriteLine("================ ZADANIE 5.1 ================\n");

            double temp_F = 50;
            double temp_C = zamien_na_C(temp_F);

            Console.WriteLine("{0,-4:F1} F to {1,-4:F1} C", temp_F, temp_C);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 5.2
            // Napisz program wczytujący 3 liczby rzeczywiste a, b, x, a następnie wywołujący
            // metodę, która sprawdza, czy liczba x należy do przedziału obustronnie otwartego(a, b).
            // Metoda sprawdzająca ma zwrócić wartość logiczną, którą należy zinterpretować w metodzie
            // Main() z podaniem stosownego komunikatu.

            Console.WriteLine("\n\n================ ZADANIE 5.2 ================\n");

            double a, b, x;


            Console.Write("Podaj początek przedziału a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\nPodaj koniec przedziału b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("\nPodaj liczbę x: ");
            x = double.Parse(Console.ReadLine());

            if (sprawdz_ab(a, b, x))
                Console.WriteLine("Liczba {0} należy do przedziału [{1} ; {2}]", x, a, b);
            else
                Console.WriteLine("Liczba {0} nie należy do przedziału [{1} ; {2}]", x, a, b);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 5.3
            // Napisz program, który ma znaleźć współrzędne punktu po przesunięciu o dany wektor.
            // W metodzie Main() wczytaj od użytkownika współrzędne punktu A oraz zadeklaruj
            // współrzędne wektora wek[3, 2], a następnie wywołaj metodę o nazwie Przesun(), która ma
            // przesunąć punkt A o wektor wek(dodać odpowiednie współrzędne). Współrzędne punktu
            // (jako dwie zmienne typu double) mają zostać przesłane do tej metody przez referencję, a
            // współrzędne wektora(także jako dwie zmienne typu double) przez wartość. Metoda
            // Przesun() ma nic nie zwracać(void), aktualne współrzędne punktu mają być pamiętane dzięki
            // użyciu argumentów przesyłanych przez referencje. Program ma wyświetlić współrzędne
            // punktu po przesunięciu o wektor wek. Przykładowo, gdyby użytkownik podał początkowe
            // współrzędne punktu A(2, 1), to wówczas program znajdzie położenie punktu A po
            // przesunięciu w miejscu o współrzędnych(5, 3)(czyli 2 + 3, 1 + 2).

            Console.WriteLine("\n\n================ ZADANIE 5.3 ================\n");

            double Ax, Ay;

            Console.Write("Podaj współrzędną Ax: ");
            Ax = double.Parse(Console.ReadLine());
            Console.Write("Podaj współrzędną Ay: ");
            Ay = double.Parse(Console.ReadLine());

            //double[] wektor_A = new double[2];
            //wektor_A[0] = Ax;
            //wektor_A[1] = Ay;

            double[] wektor_B = { 3, 2 };

            Console.WriteLine("Wektor A [  {0, -6};{1, 6}  ]", Ax, Ay);
            Console.WriteLine("Wektor B [  {0, -6};{1, 6}  ]", wektor_B[0], wektor_B[1]);

            Przesun(ref Ax, ref Ay, wektor_B[0], wektor_B[1]);

            Console.WriteLine("Wektor A po przesunięciu o wektor B: A [  {0, -6};{1, 6}  ]", Ax, Ay);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 5.4
            // Napisz program, który mnoży elementy tablicy jednowymiarowej przez zadaną liczbę.
            // Mnożenie ma być wykonane w metodzie statycznej przyjmującej jako argumenty tablicę typu
            // int oraz liczbę całkowitą(mnożnik).
            // a) Wewnątrz metody tworzona jest nowa tablica wynikowa, która ma być zwrócona
            // przez metodę.
            // b) Wyniki mnożenia elementów tablicy mają zostać umieszczone w tablicy będącej
            // argumentem metody (w tym wariancie metoda ma niczego nie zwracać)

            Console.WriteLine("\n\n================ ZADANIE 5.4 ================\n");

            int rozmiar4 = 10;
            int mnoznik = 2;

            int[] tab4 = new int[rozmiar4];
            int[] tab4_m = new int[rozmiar4];
            Random rand = new Random();

            for (int i = 0; i < tab4.Length; i++)
                tab4[i] = rand.Next(1, 20);

            foreach (int x4 in tab4)
                Console.Write("{0, -4}", x4);

            tab4_m = skalar_mnoz_A(tab4, tab4.Length, mnoznik);

            Console.WriteLine("\nTablica po przemnożeniu przez {0}:", mnoznik);
            foreach (int x5 in tab4_m)
                Console.Write("{0, -4}", x5);

            skalar_mnoz_B(tab4_m, mnoznik);

            Console.WriteLine("\nTablica po następnym przemnożeniu przez {0}:", mnoznik);
            foreach (int x6 in tab4_m)
                Console.Write("{0, -4}", x6);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 5.5
            // Napisz program, który mnoży elementy tablicy jednowymiarowej przez zadaną liczbę.
            // Mnożenie ma być wykonane w metodzie statycznej przyjmującej jako argumenty tablicę typu
            // int oraz liczbę całkowitą(mnożnik).
            // a) Wewnątrz metody tworzona jest nowa tablica wynikowa, która ma być zwrócona
            // przez metodę.
            // b) Wyniki mnożenia elementów tablicy mają zostać umieszczone w tablicy będącej
            // argumentem metody (w tym wariancie metoda ma niczego nie zwracać)

            Console.WriteLine("\n\n================ ZADANIE 5.5 ================\n");

            int dl, szer;
            char znak;

            Console.Write("Podaj długość: ");
            dl = int.Parse(Console.ReadLine());
            Console.Write("Podaj szerokość: ");
            szer = int.Parse(Console.ReadLine());
            Console.Write("Podaj znak: ");
            znak = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}  {1}   {2}", dl, szer, znak);

            Rysuj(dl, szer, znak);
            Console.WriteLine();
            Rysuj(szer, dl, znak);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 5.6
            // Uzupełnij program z zadania 5.4 (dowolny wariant) o metodę przeładowaną
            // przyjmującą tablicę typu string oraz mnożnik typu int.W tym przypadku metoda ma powielać
            // łańcuch znaków(konkatenować tyle razy, ile wynika z mnożnika).Przykładowo dla tablicy o
            // elementach { "ala", "kot", "dom"}
            // oraz mnożniku 2 program powinien wyświetlić tablicę
            // { "alaala", "kotkot", "domdom"}.

            Console.WriteLine("\n\n================ ZADANIE 5.6 ================\n");

            string[] tab_str = { "ala", "kot", "dom" };
            int mnoznik_6 = 3;

            Console.WriteLine("Oryginalna tablica: ");
            foreach (string napis in tab_str)
                Console.Write("{0} ", napis);

            mnoz_lancuch(tab_str, mnoznik_6);

            Console.WriteLine("\n\nTablica powielona {0} razy: ", mnoznik_6);
            foreach (string napis in tab_str)
                Console.Write("{0} ", napis);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 5.7
            // Napisz statyczną metodę, która oblicza wyrażenie:
            // W = (x + 1) + (x + 2) + (x + 3) + .......+(x + n).
            // W metodzie Main() wywołaj funkcję dla x i n (liczb naturalnych) wczytanych z klawiatury

            Console.WriteLine("\n\n================ ZADANIE 5.7 ================\n");

            int x_7, n_7;
            int wynik_7i = 0;
            int wynik_7r = 0;

            Console.Write("Podaj x: ");
            x_7 = int.Parse(Console.ReadLine());
            Console.Write("Podaj n: ");
            n_7 = int.Parse(Console.ReadLine());

            Console.WriteLine("W(x) dla x = {0}, n = {1}", x_7, n_7);

            wynik_7i = W_x_iter(x_7, n_7);
            wynik_7r = W_x_rek(x_7, n_7);

            Console.Write("\nIteracyjnie: {0}", wynik_7i);
            Console.Write("\nRekurencyjnie: {0}", wynik_7r);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 5.8
            // Napisz metodę, która oblicza sumę cyfr liczby naturalnej x. W programie głównym
            // wywołaj funkcję dla x wczytanego z klawiatury.Przykładowo jeśli użytkownik wpisze 125,
            // to metoda powinna zwrócić wartość 8(1 + 2 + 5 = 8).

            Console.WriteLine("\n\n================ ZADANIE 5.8 ================\n");

            int x8;
            int wynik_8;

            Console.Write("Podaj liczbę: ");
            x8 = int.Parse(Console.ReadLine());

            wynik_8 = Suma_cyfr(x8);

            Console.WriteLine("{0} ==> {1}", x8, wynik_8);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 5.9
            // Wykonaj program znajdujący n-ty wyraz ciągu Fibonacciego
            // Wykonaj program w dwóch wariantach: w jednym metoda znajdująca wyraz ciągu ma
            // być rekurencyjna, a w drugim ma wykorzystać iteracyjne podejście(z użyciem pętli)


            Console.WriteLine("\n\n================ ZADANIE 5.9 ================\n");

            int x_9 = 12;

            Console.Write("Podaj wyraz ciągu Fibonacciego: ");
            x_9 = int.Parse(Console.ReadLine());

            Console.WriteLine("F[{0}] = {1}", x_9, CiagFin_r(x_9));
            Console.WriteLine("F[{0}] = {1}", x_9, CiagFin_i(x_9));

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 5.10
            // Wykonaj program znajdujący n-ty wyraz ciągu Fibonacciego
            // Wykonaj program w dwóch wariantach: w jednym metoda znajdująca wyraz ciągu ma
            // być rekurencyjna, a w drugim ma wykorzystać iteracyjne podejście(z użyciem pętli)

            Console.WriteLine("\n\n================ ZADANIE 5.10 ================\n");

            for (int i = 0; i < 6; i++)
                Console.WriteLine("[{0}]: {1}", i, Oblicz(i));

            // n = 5   ==>  (5 + Oblicz(4))  ==> 5 + 10 = 15
            // n = 4   ==>  (4 + Oblicz(3))  ==> 4 + 6 = 10
            // n = 3   ==>  (3 + Oblicz(2))  ==> 3 + 3 = 6
            // n = 2   ==>  (2 + Oblicz(1))  ==> 2 + 1 = 3 
            // n = 1   ==>  1
            // n = 0   ==>  1

            Console.Write("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }

}
