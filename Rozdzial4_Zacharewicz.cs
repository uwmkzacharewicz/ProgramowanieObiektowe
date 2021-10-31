using System;

namespace Zadania_ps
{
    class Program
    {
        static void Main(string[] args)
        {

            // ZADANIE 4.1
            // Napisz program, który pozwoli zapełnić n–elementową tablicę jednowymiarową
            // liczb całkowitych wartościami podanymi przez użytkownika.
            // Na początku działania programu użytkownik podaje liczbę elementów tablicy,
            // a następnie poszczególne wartości jej elementów.
            // Po wypełnieniu całej tablicy program powinien wypisać je w oknie konsoli.

            Console.WriteLine("================ ZADANIE 4.1 ================\n");

            int n;

            Console.Write("Podaj rozmiar tablicy: ");
            n = int.Parse(Console.ReadLine());

            int[] tab1 = new int[n];

            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write("Podaj [{0}] element tablicy: ", i + 1);
                tab1[i] = int.Parse(Console.ReadLine());
            }
   
            for (int i = 0; i < tab1.Length; i++)
                Console.Write("{0,6} ", tab1[i]);

            Console.WriteLine("\nForeach: ");
            foreach (int x in tab1)
                Console.Write("{0,6} ", x);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 4.2
            // Napisz program kopiujący z danej tablicy liczb całkowitych tab1 do nowej tablicy tab2
            // wyłącznie wartości dodatnie.
            // Obie tablice mają być jednowymiarowe o rozmiarze równym 10
            // (czyli 10 - elemetowe).
            // Elementy pierwszej tablicy(tab1) należy wpisać w trakcie deklaracji
            // tej tablicy.

            Console.WriteLine("\n\n================ ZADANIE 4.2 ================\n");

            int rozmiar = 10;

            int[] tab_1 = new int[rozmiar];
            int[] tab_2 = new int[rozmiar];

            
            // for (int i = 0; i < tab1.Length; i++)
            // {
            //    Console.Write("Podaj [{0}] element tablicy: ", i + 1);
            //    tab1[i] = int.Parse(Console.ReadLine());
            // } 

            Random rand = new Random();
            for(int i = 0; i < rozmiar; i++)
                tab_1[i] = rand.Next(-10, 10);

            Console.Write("Tablica 1: ");
            foreach (int x in tab_1)
                Console.Write("{0, -6} ", x);

            for(int i = 0; i < rozmiar; i++)
            {
                if (tab_1[i] > 0)
                    tab_2[i] = tab_1[i];
            }

            Console.Write("\nTablica 2: ");
            foreach (int y in tab_2)
                Console.Write("{0, -6} ", y);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 4.3
            // Napisz program wyświetlający informacje o wypełnionej przez użytkownika tablicy nelementowej:
            // - wartość i numer pozycji największego elementu,
            // - wartość i numer pozycji najmniejszego elementu,
            // - średnia wartości wszystkich elementów tablicy,
            // - liczba dodatnich elementów tablicy.

            Console.WriteLine("\n\n================ ZADANIE 4.3 ================\n");

            int w_max, i_max;
            int w_min, i_min;
            double suma = 0, srednia = 0;
            int dodatnie = 0;

            int rozmiar3 = 15;

            int[] tab_3 = new int[rozmiar3];

            Random rand1 = new Random();
            for (int i = 0; i < rozmiar3; i++)
                tab_3[i] = rand1.Next(-100, 100);

            Console.WriteLine("Twoja tablica: ");
            foreach (int x in tab_3)
                Console.Write("{0, 6} ", x);

            i_max = i_min = 0;
            w_max = w_min = tab_3[0];

            for(int i = 0; i < rozmiar3; i++)
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
                    dodatnie ++;

                suma += tab_3[i];
            }

            srednia = suma / rozmiar3;

            Console.WriteLine("\n\nPODSUMOWANIE:");
            Console.WriteLine("Wartosc MAX: [{0}] {1}", i_max, w_max);
            Console.WriteLine("Wartosc MIN: [{0}] {1}", i_min, w_min);
            Console.WriteLine("Liczba dodatnich elementów: {0}", dodatnie);
            Console.WriteLine("SUMA: {0}", suma);
            Console.WriteLine("ŚREDNIA: {0, 2:F2}", srednia);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 4.4
            // Napisz program, który podaje, ile jest liczb pierwszych w tablicy 100 elementowej typu
            // int.Tablicę należy wypełnić losowymi wartościami.

            Console.WriteLine("\n\n================ ZADANIE 4.4 ================\n");

            int rozmiar4 = 100;
            int licznik_p = 0;
            bool czy_pierwsza = false;

            int[] tab_4 = new int[rozmiar4];

            Random rand2 = new Random();
            for (int i = 0; i < rozmiar4; i++)
                tab_4[i] = rand2.Next(1, 1000);

            Console.WriteLine("Twoja tablica: ");
            for (int i = 0; i < rozmiar4; i++)
            {
                if (i % 10 == 0 && i != 0)
                    Console.Write("\n");
                Console.Write("{0,-5} ", tab_4[i]);
            }

            Console.WriteLine("\n");

            for (int i = 0; i < rozmiar4; i++)
            {
                for (int j = 2; j < tab_4[i]; j++)
                {
                    if (tab_4[i] % j == 0)
                    {
                        czy_pierwsza = false;
                        break;
                    }
                    czy_pierwsza = true;
                }

                if (czy_pierwsza)
                    licznik_p++;  
            }

            Console.WriteLine("W tablicy jest {0} liczb pierwszych", licznik_p);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 4.5
            // Dana jest n-elementowa tablica liczb całkowitych tab1. Napisz program kopiujący
            // wartości elementów tablicy tab1 do tablicy tab2(o tym samym rozmiarze) z przesunięciem
            // o jedną pozycje. To znaczy, że element w tablicy źródłowej o indeksie 0 powinien
            // znaleźć się w tablicy docelowej pod indeksem 1, element o indeksie 1 ma być w tablicy
            // docelowej pod indeksem 2 itd.Element ostatni tablicy źródłowej ma być elementem
            // o indeksie 0 w tablicy docelowej.

            Console.WriteLine("\n\n================ ZADANIE 4.5 ================\n");

            int rozmiar5 = 10;
            
            int[] tab_5A = new int[rozmiar5];
            int[] tab_5B = new int[rozmiar5];

            Random rand3 = new Random();
            for (int i = 0; i < rozmiar5; i++)
                tab_5A[i] = rand3.Next(1, 100);

            Console.WriteLine("\nTwoja tablica: ");
            
            foreach (int x in tab_5A)
                Console.Write("{0,3} ", x);

            for (int i = 0; i < rozmiar5 - 1; i++)            
                tab_5B[i+1] = tab_5A[i];
            tab_5B[0] = tab_5A[rozmiar5-1];

            Console.WriteLine("\nTwoja tablica: ");

            foreach (int x in tab_5B)
                Console.Write("{0,3} ", x);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 4.6
            // Napisz program, który deklaruje i inicjalizuje dwuwymiarową tablicę liczb
            // rzeczywistych o rozmiarze 5 x 5.
            // Program ma wyświetlić elementy tablicy(wiersz po wierszu),
            // a następnie wyświetlić sumę elementów znajdujących się na głównej przekątnej tablicy
            // (główna przekątna – od elementu o indeksach 0, 0 do elementu o indeksach n,n)

            Console.WriteLine("\n\n================ ZADANIE 4.6 ================\n");

            int rozmiar6 = 5;
            double suma6 = 0;

            double[,] tab_6 = new double[rozmiar6, rozmiar6];

            Random rand4 = new Random();
            for (int w = 0; w < rozmiar6; w++)
                for(int k = 0; k < rozmiar6; k++)
                    tab_6[w, k] = rand4.NextDouble() * 100;

            for (int w = 0; w < rozmiar6; w++)
            {
                for (int k = 0; k < rozmiar6; k++)
                    Console.Write("{0,8:F2}", tab_6[w, k]);
                Console.WriteLine("");
            }

            // zliczenie sumy przekatnej
            for (int i = 0; i < rozmiar6; i++)
                suma6 += tab_6[i, i];

            Console.WriteLine("\nSuma przekątnej: {0,5:F2}", suma);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 4.7
            // Napisz program, który dodaje dwie macierze o rozmiarze 2 x 3.
            // Elementy macierzy należy umieścić w tablicach dwuwymiarowych w trakcie deklaracji.
            // Program ma wyświetlić macierz wynikową.
            // Wskazówka: Dodawanie macierzy – macierz wynikowa C zawiera A+B

            Console.WriteLine("\n\n================ ZADANIE 4.7 ================\n");

            int w_7 = 2;
            int k_7 = 3;

            int[,] macierz_A = new int[w_7, k_7];
            int[,] macierz_B = new int[w_7, k_7];
            int[,] macierz_C = new int[w_7, k_7];

            Random rand5 = new Random();
            for (int w = 0; w < w_7; w++)
                for (int k = 0; k < k_7; k++)
                {
                    macierz_A[w, k] = rand5.Next(1, 100);
                    macierz_B[w, k] = rand5.Next(1, 100);
                    macierz_C[w, k] = macierz_A[w, k] + macierz_B[w, k];
                }

            Console.WriteLine("Macierz A: ");

            for (int w = 0; w < w_7; w++)
            {
                for (int k = 0; k < k_7; k++)
                    Console.Write("{0,5}", macierz_A[w, k]);
                Console.WriteLine("");
            }

            Console.WriteLine("\nMacierz B: ");

            for (int w = 0; w < w_7; w++)
            {
                for (int k = 0; k < k_7; k++)
                    Console.Write("{0,5}", macierz_B[w, k]);
                Console.WriteLine("");
            }

            Console.WriteLine("\nMacierz C (A+B): ");

            for (int w = 0; w < w_7; w++)
            {
                for (int k = 0; k < k_7; k++)
                    Console.Write("{0,5}", macierz_C[w, k]);
                Console.WriteLine("");
            }

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 4.8
            // Uzupełnij poniższy kod programu o wszystkie dni tygodnia i przy użyciu pętli wyświetl
            // zawartość tablicy: w każdym wierszu dany dzień tygodnia w trzech językach(polskim,
            // angielskim, niemieckim).

            Console.WriteLine("\n\n================ ZADANIE 4.8 ================\n");

            string[,] dniTygodnia;
            dniTygodnia = new string[7, 3]; // pamiętaj o zmianie rozmiaru tablicy
            
            dniTygodnia[0, 0] = "poniedzialek";
            dniTygodnia[0, 1] = "monday";
            dniTygodnia[0, 2] = "montag";

            dniTygodnia[1, 0] = "wtorek";
            dniTygodnia[1, 1] = "tuesday";
            dniTygodnia[1, 2] = "dienstag";

            dniTygodnia[2, 0] = "środa";
            dniTygodnia[2, 1] = "wednesday";
            dniTygodnia[2, 2] = "mittwoch";

            dniTygodnia[3, 0] = "czwartek";
            dniTygodnia[3, 1] = "thursday";
            dniTygodnia[3, 2] = "donnerstag";

            dniTygodnia[4, 0] = "piątek";
            dniTygodnia[4, 1] = "friday";
            dniTygodnia[4, 2] = "freitag";

            dniTygodnia[5, 0] = "sobota";
            dniTygodnia[5, 1] = "saturday";
            dniTygodnia[5, 2] = "samstag";

            dniTygodnia[6, 0] = "niedziela";
            dniTygodnia[6, 1] = "sunday";
            dniTygodnia[6, 2] = "sonntag";

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0, 15}", dniTygodnia[i, j]);
                Console.WriteLine("");
            }

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 4.9
            // Napisz program obliczający liczbę wyrazów w łańcuchu znaków wprowadzonym przez
            // użytkownika. Należy przyjąć, że wyrazy to ciągi znaków rozdzielone spacją.

            Console.WriteLine("\n\n================ ZADANIE 4.9 ================\n");

            int licznik_wyr = 1;
            string zdanie;

            Console.Write("Wprowadź łańcuch znaków: ");
            zdanie = Console.ReadLine();

            Console.Write("{0}", zdanie);

            if (zdanie.Length > 0)
            {
                foreach (char litera in zdanie)
                    if (litera == ' ')
                        licznik_wyr++;
            }
            else
                Console.WriteLine("\nNic nie wpisałeś :(");

            Console.WriteLine("\n\nIlosc wyrazow: {0}", licznik_wyr);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 4.10
            // Napisać program, który pobierze datę w formacie DD-MM-RRRR, z której pobierze
            // miesiąc i wyświetli jego nazwę słownie.

            Console.WriteLine("\n\n================ ZADANIE 4.10 ================\n");

            string data_10;
            string miesiac;
            string[] tab_m =    {"styczeń", "luty", "marzec", "kwiecień",
                                "maj", "czerwiec", "lipiec", "sierpień", "wrzesień",
                                "październik", "listopad", "grudzień" };
            int nr_mies;

            Console.Write("Podaj datę w formacie DD-MM-RRRR: ");

            data_10 = Console.ReadLine();
            miesiac = data_10.Substring(3, 2);

            if (!int.TryParse(miesiac, out nr_mies))
                Console.WriteLine("{0} nie jest liczbą", miesiac);

            // nr_mies = Convert.ToInt32(miesiac);

            if (nr_mies > 0 && nr_mies <= 12)
            {
                Console.WriteLine("{0}", tab_m[nr_mies-1]);
            }
            else
            {
                Console.WriteLine("Nieznany miesiąc...");
                return;
            }

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 4.11
            // Napisz program analizujący częstość występowania poszczególnych znaków
            // w łańcuchu znaków wprowadzonym przez użytkownika.Np.dla wprowadzonego tekstu
            // „abrakadabra” program powinien wyświetlić informacje:
            // a – 5, b – 2, r – 2, k – 1, d – 1.

            Console.WriteLine("\n\n================ ZADANIE 4.11 ================\n");

            string tekst = "abrakadabra";
            int licznik;

            Console.Write("Wpisz łańcuch: ");
            tekst = Console.ReadLine();

            for (int i = 0; i < tekst.Length; i++)
            {
                licznik = 1;

                for(int j = i+1; j < tekst.Length; j++)
                {    
                    if (tekst[i] == tekst[j])
                    {
                        tekst = tekst.Remove(j, 1);
                        licznik++;
                        j--;
                    }
                }
                Console.WriteLine("{0} - {1}", tekst[i], licznik);
            }

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 4.12
            // Napisz program, który dla zadeklarowanej niżej zmiennej łańcuchowej wyświetli jej
            // zawartość, poda liczbę wierszy oraz poda liczbę znaków w każdym wierszu

            Console.WriteLine("\n\n================ ZADANIE 4.12 ================\n");

            int licznik_znakow = 0;
            int ilosc_wierszy = 0;

            string puchatek =  "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
                            "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
                            "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
                            "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
                            "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";

            ilosc_wierszy = 0;

            for (int i = 0; i < puchatek.Length; i++)
            {
                Console.Write(puchatek[i]);
                licznik_znakow++;

                if (puchatek[i] == '\n' || i == puchatek.Length-1)
                {
                    if (i == puchatek.Length - 1)
                        Console.WriteLine("");

                    Console.WriteLine("Liczba znaków: {0}", licznik_znakow);
                    licznik_znakow = 0;

                    ilosc_wierszy++;
                    Console.WriteLine("");                    
                }
            }

            Console.WriteLine("\nIlosc wierszy: {0}", ilosc_wierszy);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 4.13
            // Napisz program, który przeanalizuje dany łańcuch pod kątem wielokrotnego
            // występowania słów w tekście. Przykładowo dla zmiennej łańcuchowej o zawartości:
            // „Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały,
            // po co się idzie – odpowiedział Puchatek” – program powinien wypisać raport o słowach powielonych
            // w tym tekście:
            // idzie – 2 razy, po – 2 razy, się – 3 razy.

            Console.WriteLine("\n\n================ ZADANIE 4.13 ================\n");

            int pozycja, start;
            int ilosc_wyst = 0;

            //string tekst_p = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały," +
            //                "po co się idzie – odpowiedział Puchatek";

            string tekst_p = "idzie, się po idzie miód z balonikiem idzie, to trzeba się starać żeby po pszczoły, żeby pszczoły nie wiedziały," +
                        "po co się idzie – odpowiedział balonik Puchatek trzeba idzie.";

            string wyraz = String.Empty;
           
            Console.WriteLine(tekst_p);

            foreach (char litera in tekst_p)
            {
                // sprawdzamy czy spacja lub przecinek

                if (litera == ' ' || litera == ',' || litera == '.')
                {
                    // jeżeli mamy już wyraz to sprawdzamy czy występuje w tekscie
                    if (wyraz != "")
                    {
                        start = 0;
                        pozycja = 0;

                        // Szukamy występowanie wyrazu, zliczamy i usuwamy go z tablicy
                        while (((pozycja = tekst_p.IndexOf(wyraz, start)) >= 0))
                        {
                            if (wyraz.Length == 1)          // jeżeli pojedyńczy znak to przerywamy pętle
                                break;
                            ilosc_wyst++;

                            tekst_p = tekst_p.Remove(pozycja, wyraz.Length);    // usuwamy znak z łańcucha
                        }

                        if (ilosc_wyst > 1)        
                            Console.WriteLine("\n{0} - {1} razy", wyraz, ilosc_wyst);

                        wyraz = "";
                        ilosc_wyst = 0;

                    }
                    // Jeżeli nie mamy wyrazu, to znaczy, że spacja lubh przecinek. Usuwamy znak
                    else
                        tekst_p = tekst_p.Remove(0, 1);
                }
                // jeżeli litera to tworzymy wyraz
                else
                    wyraz += litera;               
                    
            }

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();


            // ZADANIE 4.14
            // W danej firmie środki trwałe mają identyfikatory złożone
            // z kilku liter, myślnika oraz czterech cyfr.
            // Te cztery cyfry to rok zakupu danego środka trwałego.
            // Przykładowe identyfikatory to:
            // KOMG - 2002, BH - 2010.
            // Napisz program, który deklaruje 5 - cio elementową tablicę typu string dla środków trwałych,
            // którą należy zainicjalizować przykładowymi identyfikatorami w czasie deklaracji.
            // Program ma dla każdego środka trwałego podać liczbę lat, jakie upłynęły od jego zakupu.

            Console.WriteLine("\n\n================ ZADANIE 4.14 ================\n");

            int ile_czasu;
            string rok_zakupu;

            // inicjalizujemy tablice z danymi
            string[] sr_trwale = { "KOMG-2002", "BH-2010", "ATX-2012", "GHRW-2011", "MKTFG-2013" };

            DateTime thisDay = DateTime.Today;
            string dzis_rok = thisDay.ToString("yyyy");

            foreach (string indeks in sr_trwale)
            {
                rok_zakupu = indeks.Substring(indeks.Length - 4, 4);
                ile_czasu = Convert.ToInt32(dzis_rok) - Convert.ToInt32(rok_zakupu);

                Console.Write("\nIndeks: {0}, zakupiono {1} lat temu", indeks, ile_czasu);
            }

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 4.15
            // Napisz program, który szyfruje podany przez użytkownika tekst prostym szyfrem
            // GA-DE-RY-PO-LU-KI

            Console.WriteLine("\n\n================ ZADANIE 4.15 ================\n");

            string szyfr = "GADERYPOLUKI";
            int idx;

            string slowo = "zaszyfruj";
            slowo = slowo.ToUpper();

            Console.WriteLine("0 1 - 2 3 - 4 5 - 6 7 - 8 9 - 10 11");
            Console.WriteLine("G A - D E - R Y - P O - L U -  K  I");

            string zaszyfr = String.Empty;

            Console.WriteLine("\nSłowo do zaszyfrowania: {0}", slowo);

            foreach (char litera in slowo)
            {
                idx = szyfr.IndexOf(litera);

                if (idx % 2 == 0)
                    zaszyfr += szyfr[idx + 1];
                else if (idx % 2 != 0 && idx > 0)
                    zaszyfr += szyfr[idx - 1];
                else
                    zaszyfr += litera;
            }

            Console.WriteLine("\nZaszyfrowane: {0}", zaszyfr);

            Console.Write("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}
