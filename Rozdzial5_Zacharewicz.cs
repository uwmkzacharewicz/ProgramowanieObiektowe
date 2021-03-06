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
            // Napisz program zawieraj??cy metod?? statyczn?? obliczaj??c?? temperatur?? w stopniach
            // Fahrenheita na temperatur?? w stopniach Celsjusza. Metoda ma przyjmowa?? jeden argument
            // (temperatur?? w stopniach Fahrenheita) i zwraca?? temperatur?? w stopniach Celsjusza

            Console.WriteLine("================ ZADANIE 5.1 ================\n");

            double temp_F = 50;
            double temp_C = zamien_na_C(temp_F);

            Console.WriteLine("{0,-4:F1} F to {1,-4:F1} C", temp_F, temp_C);

            Console.Write("\nNaci??nij dowolny klawisz, aby kontynuowa??...");
            Console.ReadKey();

            // ZADANIE 5.2
            // Napisz program wczytuj??cy 3 liczby rzeczywiste a, b, x, a nast??pnie wywo??uj??cy
            // metod??, kt??ra sprawdza, czy liczba x nale??y do przedzia??u obustronnie otwartego(a, b).
            // Metoda sprawdzaj??ca ma zwr??ci?? warto???? logiczn??, kt??r?? nale??y zinterpretowa?? w metodzie
            // Main() z podaniem stosownego komunikatu.

            Console.WriteLine("\n\n================ ZADANIE 5.2 ================\n");

            double a, b, x;


            Console.Write("Podaj pocz??tek przedzia??u a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\nPodaj koniec przedzia??u b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("\nPodaj liczb?? x: ");
            x = double.Parse(Console.ReadLine());

            if (sprawdz_ab(a, b, x))
                Console.WriteLine("Liczba {0} nale??y do przedzia??u [{1} ; {2}]", x, a, b);
            else
                Console.WriteLine("Liczba {0} nie nale??y do przedzia??u [{1} ; {2}]", x, a, b);

            Console.Write("\nNaci??nij dowolny klawisz, aby kontynuowa??...");
            Console.ReadKey();

            // ZADANIE 5.3
            // Napisz program, kt??ry ma znale???? wsp????rz??dne punktu po przesuni??ciu o dany wektor.
            // W metodzie Main() wczytaj od u??ytkownika wsp????rz??dne punktu A oraz zadeklaruj
            // wsp????rz??dne wektora wek[3, 2], a nast??pnie wywo??aj metod?? o nazwie Przesun(), kt??ra ma
            // przesun???? punkt A o wektor wek(doda?? odpowiednie wsp????rz??dne). Wsp????rz??dne punktu
            // (jako dwie zmienne typu double) maj?? zosta?? przes??ane do tej metody przez referencj??, a
            // wsp????rz??dne wektora(tak??e jako dwie zmienne typu double) przez warto????. Metoda
            // Przesun() ma nic nie zwraca??(void), aktualne wsp????rz??dne punktu maj?? by?? pami??tane dzi??ki
            // u??yciu argument??w przesy??anych przez referencje. Program ma wy??wietli?? wsp????rz??dne
            // punktu po przesuni??ciu o wektor wek. Przyk??adowo, gdyby u??ytkownik poda?? pocz??tkowe
            // wsp????rz??dne punktu A(2, 1), to w??wczas program znajdzie po??o??enie punktu A po
            // przesuni??ciu w miejscu o wsp????rz??dnych(5, 3)(czyli 2 + 3, 1 + 2).

            Console.WriteLine("\n\n================ ZADANIE 5.3 ================\n");

            double Ax, Ay;

            Console.Write("Podaj wsp????rz??dn?? Ax: ");
            Ax = double.Parse(Console.ReadLine());
            Console.Write("Podaj wsp????rz??dn?? Ay: ");
            Ay = double.Parse(Console.ReadLine());

            //double[] wektor_A = new double[2];
            //wektor_A[0] = Ax;
            //wektor_A[1] = Ay;

            double[] wektor_B = { 3, 2 };

            Console.WriteLine("Wektor A [  {0, -6};{1, 6}  ]", Ax, Ay);
            Console.WriteLine("Wektor B [  {0, -6};{1, 6}  ]", wektor_B[0], wektor_B[1]);

            Przesun(ref Ax, ref Ay, wektor_B[0], wektor_B[1]);

            Console.WriteLine("Wektor A po przesuni??ciu o wektor B: A [  {0, -6};{1, 6}  ]", Ax, Ay);

            Console.Write("\nNaci??nij dowolny klawisz, aby kontynuowa??...");
            Console.ReadKey();

            // ZADANIE 5.4
            // Napisz program, kt??ry mno??y elementy tablicy jednowymiarowej przez zadan?? liczb??.
            // Mno??enie ma by?? wykonane w metodzie statycznej przyjmuj??cej jako argumenty tablic?? typu
            // int oraz liczb?? ca??kowit??(mno??nik).
            // a) Wewn??trz metody tworzona jest nowa tablica wynikowa, kt??ra ma by?? zwr??cona
            // przez metod??.
            // b) Wyniki mno??enia element??w tablicy maj?? zosta?? umieszczone w tablicy b??d??cej
            // argumentem metody (w tym wariancie metoda ma niczego nie zwraca??)

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

            Console.WriteLine("\nTablica po przemno??eniu przez {0}:", mnoznik);
            foreach (int x5 in tab4_m)
                Console.Write("{0, -4}", x5);

            skalar_mnoz_B(tab4_m, mnoznik);

            Console.WriteLine("\nTablica po nast??pnym przemno??eniu przez {0}:", mnoznik);
            foreach (int x6 in tab4_m)
                Console.Write("{0, -4}", x6);

            Console.Write("\nNaci??nij dowolny klawisz, aby kontynuowa??...");
            Console.ReadKey();

            // ZADANIE 5.5
            // Napisz program, kt??ry mno??y elementy tablicy jednowymiarowej przez zadan?? liczb??.
            // Mno??enie ma by?? wykonane w metodzie statycznej przyjmuj??cej jako argumenty tablic?? typu
            // int oraz liczb?? ca??kowit??(mno??nik).
            // a) Wewn??trz metody tworzona jest nowa tablica wynikowa, kt??ra ma by?? zwr??cona
            // przez metod??.
            // b) Wyniki mno??enia element??w tablicy maj?? zosta?? umieszczone w tablicy b??d??cej
            // argumentem metody (w tym wariancie metoda ma niczego nie zwraca??)

            Console.WriteLine("\n\n================ ZADANIE 5.5 ================\n");

            int dl, szer;
            char znak;

            Console.Write("Podaj d??ugo????: ");
            dl = int.Parse(Console.ReadLine());
            Console.Write("Podaj szeroko????: ");
            szer = int.Parse(Console.ReadLine());
            Console.Write("Podaj znak: ");
            znak = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}  {1}   {2}", dl, szer, znak);

            Rysuj(dl, szer, znak);
            Console.WriteLine();
            Rysuj(szer, dl, znak);

            Console.Write("\nNaci??nij dowolny klawisz, aby kontynuowa??...");
            Console.ReadKey();

            // ZADANIE 5.6
            // Uzupe??nij program z zadania 5.4 (dowolny wariant) o metod?? prze??adowan??
            // przyjmuj??c?? tablic?? typu string oraz mno??nik typu int.W tym przypadku metoda ma powiela??
            // ??a??cuch znak??w(konkatenowa?? tyle razy, ile wynika z mno??nika).Przyk??adowo dla tablicy o
            // elementach { "ala", "kot", "dom"}
            // oraz mno??niku 2 program powinien wy??wietli?? tablic??
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

            Console.Write("\nNaci??nij dowolny klawisz, aby kontynuowa??...");
            Console.ReadKey();

            // ZADANIE 5.7
            // Napisz statyczn?? metod??, kt??ra oblicza wyra??enie:
            // W = (x + 1) + (x + 2) + (x + 3) + .......+(x + n).
            // W metodzie Main() wywo??aj funkcj?? dla x i n (liczb naturalnych) wczytanych z klawiatury

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

            Console.Write("\nNaci??nij dowolny klawisz, aby kontynuowa??...");
            Console.ReadKey();

            // ZADANIE 5.8
            // Napisz metod??, kt??ra oblicza sum?? cyfr liczby naturalnej x. W programie g????wnym
            // wywo??aj funkcj?? dla x wczytanego z klawiatury.Przyk??adowo je??li u??ytkownik wpisze 125,
            // to metoda powinna zwr??ci?? warto???? 8(1 + 2 + 5 = 8).

            Console.WriteLine("\n\n================ ZADANIE 5.8 ================\n");

            int x8;
            int wynik_8;

            Console.Write("Podaj liczb??: ");
            x8 = int.Parse(Console.ReadLine());

            wynik_8 = Suma_cyfr(x8);

            Console.WriteLine("{0} ==> {1}", x8, wynik_8);

            Console.Write("\nNaci??nij dowolny klawisz, aby kontynuowa??...");
            Console.ReadKey();

            // ZADANIE 5.9
            // Wykonaj program znajduj??cy n-ty wyraz ci??gu Fibonacciego
            // Wykonaj program w dw??ch wariantach: w jednym metoda znajduj??ca wyraz ci??gu ma
            // by?? rekurencyjna, a w drugim ma wykorzysta?? iteracyjne podej??cie(z u??yciem p??tli)


            Console.WriteLine("\n\n================ ZADANIE 5.9 ================\n");

            int x_9 = 12;

            Console.Write("Podaj wyraz ci??gu Fibonacciego: ");
            x_9 = int.Parse(Console.ReadLine());

            Console.WriteLine("F[{0}] = {1}", x_9, CiagFin_r(x_9));
            Console.WriteLine("F[{0}] = {1}", x_9, CiagFin_i(x_9));

            Console.Write("\nNaci??nij dowolny klawisz, aby kontynuowa??...");
            Console.ReadKey();

            // ZADANIE 5.10
            // Wykonaj program znajduj??cy n-ty wyraz ci??gu Fibonacciego
            // Wykonaj program w dw??ch wariantach: w jednym metoda znajduj??ca wyraz ci??gu ma
            // by?? rekurencyjna, a w drugim ma wykorzysta?? iteracyjne podej??cie(z u??yciem p??tli)

            Console.WriteLine("\n\n================ ZADANIE 5.10 ================\n");

            for (int i = 0; i < 6; i++)
                Console.WriteLine("[{0}]: {1}", i, Oblicz(i));

            // n = 5   ==>  (5 + Oblicz(4))  ==> 5 + 10 = 15
            // n = 4   ==>  (4 + Oblicz(3))  ==> 4 + 6 = 10
            // n = 3   ==>  (3 + Oblicz(2))  ==> 3 + 3 = 6
            // n = 2   ==>  (2 + Oblicz(1))  ==> 2 + 1 = 3 
            // n = 1   ==>  1
            // n = 0   ==>  1

            Console.Write("\nNaci??nij dowolny klawisz, aby zako??czy??...");
            Console.ReadKey();
        }
    }

}
