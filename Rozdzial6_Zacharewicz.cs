using System;

namespace Zadania_ps
{
    public class Prostokat      // ZADANIE 1,2,3
    {
        private double dlugosc;
        private double szerokosc;

        public Prostokat()
        {
            dlugosc = 0;
            szerokosc = 0;
        }
        public Prostokat(double dl, double szer)
        {
            dlugosc = dl;
            szerokosc = szer;
        }

        private double powierzchnia()
        {
            return dlugosc * szerokosc;
        }

        private double obwod()
        {
            return 2 * (dlugosc + szerokosc);
        }

        public void Prezentuj()
        {
            Console.WriteLine("Pole: {0}, Obwód: {1}", powierzchnia(), obwod());
        }

        public static double podaj_najwiek(Prostokat[] tab)
        {
            double naj = tab[0].powierzchnia();

            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i].powierzchnia() > naj)
                    naj = tab[i].powierzchnia();
            }

            return naj;
        }
    }

    class Urzadzenie        // ZADANIE 4
    {
        private double stan_pocz { get; set; }
        private double stan_biez;
        private bool stan_popr;
        public Urzadzenie()
        {
            this.stan_pocz = 0;
            this.stan_biez = 0;
            this.stan_popr = true;
        }
        public void wprowadz_stan_pocz(double p)
        {
            this.stan_pocz = p;
        }
        public bool sprawdz_stan(int stan_l)
        {
            bool stan;

            if (stan_pocz > stan_l)
                stan = false;
            else
                stan = true;

            return stan;
        }

        public void wprowadz_stan_biez(double b)
        {
            this.stan_biez = b;
        }

        public void pokaz_stan_pocz()
        {
            Console.WriteLine("Stan początkowy: {0, 10}", this.stan_pocz);
        }

        public void pokaz_stan_biez()
        {
            Console.WriteLine("Stan bieżący: {0, 13}", this.stan_biez);
        }
        public void pokaz_zuzycie()
        {
            if (stan_popr)
                Console.WriteLine("Zużycie energi: {0}", stan_biez - stan_pocz);
            else
                Console.WriteLine("Błędne dane");
        }

    }

    class Punkt     // ZADANIE 5
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public Punkt()
        {
            this.x = 0;
            this.y = 0;
        }
        public Punkt(double wsp_x, double wsp_y)
        {
            this.x = wsp_x;
            this.y = wsp_y;
        }
        public void Przesun(double w_a, double w_b)
        {
            this.x = this.x + w_a;
            this.y = this.y + w_b;
        }
        public void Wyswietl()
        {
            Console.WriteLine($"Współrzędne pkt: [  {this.x,-4};{this.y,4}  ]");
        }

        // ZADANIE 6
        private static double dlugosc_odcinka(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public static void sprawdz_prosta(Punkt[] tab)
        {
            double AB, AC, BC;

            if (tab.Length != 3)
            {
                Console.WriteLine("Błędna liczba punktów.");
                return;
            }

            // pkt A => tab[0]
            // pkt B => tab[1]
            // pkt C => tab[2]

            AB = dlugosc_odcinka(tab[0].x, tab[0].y, tab[1].x, tab[1].y);
            AC = dlugosc_odcinka(tab[0].x, tab[0].y, tab[2].x, tab[2].y);
            BC = dlugosc_odcinka(tab[1].x, tab[1].y, tab[2].x, tab[2].y);

            Console.WriteLine($"|AB| = {AB,0:F2}, |AC| = {AC,0:F2}, |BC| = {BC,0:F2}");

            // Punkty A, B, C leżą na jednej prostej jeżeli
            // |AC|=|AB|+|BC| lub
            // |AB|=|AC|+|CB| lub
            // |BC|=|AB|+|AC|

            if (AC == (AB + BC))
                Console.WriteLine("Punkty leżą na jednej prostej");
            else
                Console.WriteLine("Punkty nie leżą na jednej prostej");
        }
    }

    // ZADANIE 7
    class Odcinek
    {
        private Punkt pkt1 { get; set; }
        private Punkt pkt2 { get; set; }

        public Odcinek(double x1, double y1, double x2, double y2)
        {
            pkt1 = new Punkt(x1, y1);
            pkt2 = new Punkt(x2, y2);
        }

        public void Wyswietl_odc()
        {
            pkt1.Wyswietl();
            pkt2.Wyswietl();
        }
        public double dlugosc_odcinka()
        {
            return Math.Sqrt(Math.Pow(pkt2.X - pkt1.X, 2) + Math.Pow(pkt2.Y - pkt1.Y, 2));
        }
    }

    class Prostopadloscian
    {
        private double a;
        private double b;
        public double H { get; set; }
        public double A
        {
            get { return this.a; }
            set
            {
                this.a = value;
            }
        }

        public double B
        {
            get { return this.b; }
            set
            {
                this.b = value;
            }
        }
        public Prostopadloscian()
        {
            this.a = 0;
            this.b = 0;
            this.H = 0;
        }
        public Prostopadloscian(double dl, double szer, double wys)
        {
            this.a = dl;
            this.b = szer;
            this.H = wys;
        }
        public Prostopadloscian(double dl, double szer)
        {
            this.a = dl;
            this.b = szer;
            this.H = 10;
        }
        public void Wyswietl()
        {
            Console.WriteLine($"a: {this.a}, b: {this.b}, h: {this.H}");
        }
        public double objetosc()
        {
            return (this.a * this.b * this.H);
        }
        public static void porownaj(Prostopadloscian p1, Prostopadloscian p2)
        {
            double obj1 = p1.objetosc();
            double obj2 = p2.objetosc();

            if (obj1 > obj2)
                Console.WriteLine("Pierwszy prostopadłościan ma większą objętość ({0})", obj1);
            else if (obj1 == obj2)
                Console.WriteLine("Prostopadłościany mają równe objętości ({0})", obj1);
            else
                Console.WriteLine("Drugi prostopadłościan ma większą objętość ({0})", obj2);
        }
    }

    // ZADANIE 6.9
    struct Prostokat_
    {
        double dlugosc;
        double szerokosc;

        public Prostokat_(double dl, double szer)
        {
            dlugosc = dl;
            szerokosc = szer;
        }
        private double powierzchnia()
        {
            return dlugosc * szerokosc;
        }
        private double obwod()
        {
            return 2 * (dlugosc + szerokosc);
        }
        public void Prezentuj()
        {
            Console.WriteLine("Pole: {0}, Obwód: {1}", powierzchnia(), obwod());
        }
    }

    struct KandydatNaStudia
    {
        public string nazwisko { get; }
        public double punktyMatematyka { get; }
        public double punktyInformatyka { get; }
        public double punktyJezykObcy { get; }

        public KandydatNaStudia(string naz, double pkt_m, double pkt_i, double pkt_o)
        {
            nazwisko = naz;
            punktyMatematyka = pkt_m;
            punktyInformatyka = pkt_i;
            punktyJezykObcy = pkt_o;
        }
        public double ilosc_pkt()
        {
            double p_mat = 0.6;
            double p_inf = 0.5;
            double p_obc = 0.2;

            return (punktyMatematyka * p_mat)
                   + (punktyInformatyka * p_inf)
                   + (punktyJezykObcy * p_obc);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            // ZADANIE 6.1
            // Napisz program, który tworzy klasę Prostokat, zawierającą dwie prywatne dane
            // składowe: dlugosc, szerokosc, dwie prywatne metody: powierzchnia(), obwod() oraz metodę
            // publiczną – Prezentuj() (która wyświetla powierzchnię i obwód prostokąta) i konstruktor
            // inicjalizujący. W metodzie Main() zdefiniuj obiekt i uruchom dla niego metodę Prezentuj()

            Console.WriteLine("================ ZADANIE 6.1 ================\n"); 

            Prostokat p1 = new Prostokat(10, 20);
            Prostokat p2 = new Prostokat(15, 20);
            Prostokat p3 = new Prostokat();

            p1.Prezentuj();
            p2.Prezentuj();
            p3.Prezentuj();

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 6.2
            // Uzupełnij program z poprzedniego zadania o definicje tablicy obiektów dla
            // prostokątów. W metodzie Main() wyświetl powierzchnie oraz obwód wszystkich prostokątów
            // w tablicy używając (wewnątrz pętli foreach) metody publicznej Prezentuj().

            Console.WriteLine("\n\n================ ZADANIE 6.2 ================\n");

            Prostokat[] tab2 = new Prostokat[5];

            tab2[0] = new Prostokat(10, 20);
            tab2[1] = new Prostokat(22, 32);
            tab2[2] = new Prostokat(14, 24);
            tab2[3] = new Prostokat(15, 25);
            tab2[4] = new Prostokat(20, 30);

            foreach (Prostokat p in tab2)
                p.Prezentuj();

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 6.3
            // Uzupełnij program z poprzedniego zadania o definicję metody statycznej, która podaje
            // powierzchnię największego prostokąta.

            Console.WriteLine("\n\n================ ZADANIE 6.3 ================\n");

            Console.WriteLine("Największe pole: {0}", Prostokat.podaj_najwiek(tab2));

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 6.4
            // Zdefiniuj klasę, która pozwoli na rejestrację zużycia energii elektrycznej. Klasa
            // powinna pozwalać na:
            // - rejestrację początkowego i bieżącego stanu licznika energii,
            // - uzyskanie danych o początkowym oraz bieżącym stanie licznika,
            // - obliczanie zużytej energii.

            Console.WriteLine("\n\n================ ZADANIE 6.4 ================\n");

            Urzadzenie urz1 = new Urzadzenie();

            int stan;

            Console.Write("Podaj stan początkowy licznika: ");
            stan = int.Parse(Console.ReadLine());

            urz1.wprowadz_stan_pocz(stan);

            Console.Write("Podaj stan bieżący licznika: ");
            stan = int.Parse(Console.ReadLine());

            while (!urz1.sprawdz_stan(stan))
            {
                Console.WriteLine("Stan bieżący nie może być mniejszy od stanu początkowego");
                Console.Write("Podaj stan bieżący: ");
                stan = int.Parse(Console.ReadLine());
            }

            urz1.wprowadz_stan_biez(stan);

            urz1.pokaz_stan_pocz();
            urz1.pokaz_stan_biez();
            urz1.pokaz_zuzycie();

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 6.5
            // Napisz program tworzący klasę Punkt do obsługi punktów na płaszczyźnie. Klasa ta ma
            // zawierać: konstruktor, którego argumentami będą współrzędne punktu, metodę składową
            // Przesun(), realizującą przesunięcie o zadane wielkości oraz metodę składową Wyswietl()
            // wypisującą aktualne współrzędne punktu. Współrzędne punktu mają być zdefiniowane
            // poprzez właściwości.

            Console.WriteLine("\n\n================ ZADANIE 6.5 ================\n");

                Punkt pkt1 = new Punkt(0.75, 2.75);

                pkt1.Wyswietl();
                pkt1.Przesun(2.25, -2.75);
                pkt1.Wyswietl();

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 6.6
            // Napisz program (używając klasy Punkt zdefiniowanej w poprzednim zadaniu), który
            // przechowuje dane o trzech punktach w tablicy obiektów i sprawdza przy pomocy statycznej
            // metody, czy leżą one na jednej prostej.

            Console.WriteLine("\n\n================ ZADANIE 6.6 ================\n");

            Punkt[] tab_pkt1 = new Punkt[3];
            tab_pkt1[0] = new Punkt(2, 5);
            tab_pkt1[1] = new Punkt(1, 3);
            tab_pkt1[2] = new Punkt(0, 1);

            Punkt[] tab_pkt2 = new Punkt[3];
            tab_pkt2[0] = new Punkt(1, 1);
            tab_pkt2[1] = new Punkt(2, 2);
            tab_pkt2[2] = new Punkt(3, 3);

            Punkt[] tab_pkt3 = new Punkt[3];
            tab_pkt3[0] = new Punkt(1, 4);
            tab_pkt3[1] = new Punkt(0, 2);
            tab_pkt3[2] = new Punkt(-2, -1);

            Console.WriteLine("TAB1: ");            
            foreach (Punkt pkt in tab_pkt1)
                pkt.Wyswietl();

            Console.WriteLine("\nDŁUGOŚCI ODCINKÓW: ");
            Punkt.sprawdz_prosta(tab_pkt1);

            Console.WriteLine("\n\nTAB2: ");
            foreach (Punkt pkt in tab_pkt2)
                pkt.Wyswietl();

            Console.WriteLine("\nDŁUGOŚCI ODCINKÓW: ");
            Punkt.sprawdz_prosta(tab_pkt2);

            Console.WriteLine("\n\nTAB3: ");
            foreach (Punkt pkt in tab_pkt3)
                pkt.Wyswietl();

            Console.WriteLine("\n\nDŁUGOŚCI ODCINKÓW: ");
            Punkt.sprawdz_prosta(tab_pkt3);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 6.7
            // Zdefiniuj klasę Odcinek składającą się z dwóch punktów klasy Punkt. W klasie Odcinek
            // zdefiniuj metodę, która obliczy długość odcinka.

            Console.WriteLine("\n\n================ ZADANIE 6.7 ================\n");

            Odcinek odc1 = new Odcinek(2, 2, 3, 4);

            odc1.Wyswietl_odc();

            double dl_odc = odc1.dlugosc_odcinka();

            Console.WriteLine($"Dlugość odcinka: {dl_odc,0:F2}");

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 6.8
            // Zdefiniuj klasę Prostopadloscian, która pozwoli na reprezentację danych opisujących
            // długość, szerokość i wysokość prostopadłościanu. W klasie zaimplementuj metody
            // pozwalające na obliczenie objętości prostopadłościanu, oraz porównanie objętości dwóch
            // prostopadłościanów

            Console.WriteLine("\n\n================ ZADANIE 6.8 ================\n");

            Prostopadloscian prp1 = new Prostopadloscian();
            Prostopadloscian prp2 = new Prostopadloscian(50, 20, 5);
            Prostopadloscian prp3 = new Prostopadloscian(30, 20);

            prp1.A = 10;
            prp1.B = 20;
            prp1.H = 50;

            Console.WriteLine();
            prp1.Wyswietl();
            Console.WriteLine($"Objętość: {prp1.objetosc()} [j^3]");
            Console.WriteLine();
            prp2.Wyswietl();
            Console.WriteLine($"Objętość: {prp2.objetosc()} [j^3]");
            Console.WriteLine();
            prp3.Wyswietl();
            Console.WriteLine($"Objętość: {prp3.objetosc()} [j^3]");

            Console.WriteLine("\nPorównanie objętości: ");
            Console.Write("prp1 z prp2: ");
            Prostopadloscian.porownaj(prp1, prp2);
            Console.Write("prp2 z prp3: ");
            Prostopadloscian.porownaj(prp2, prp3);
            Console.Write("prp1 z prp3: ");
            Prostopadloscian.porownaj(prp1, prp3);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 6.9
            // Wykonaj zadania 6.1 oraz 6.2 z użyciem struktury (zamiast klasy)

            Console.WriteLine("\n\n================ ZADANIE 6.9 ================\n");
            
            Prostokat_ pr_s1 = new Prostokat_(12, 20);
            Prostokat_ pr_s2 = new Prostokat_(8, 4);

            pr_s1.Prezentuj();
            pr_s2.Prezentuj();

            Prostokat_[] pr_s_tab = new Prostokat_[3];

            pr_s_tab[0] = new Prostokat_(10, 12);
            pr_s_tab[1] = new Prostokat_(12, 15);
            pr_s_tab[2] = new Prostokat_(15, 20);

            foreach (Prostokat_ p in pr_s_tab)
                p.Prezentuj();

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 6.10
            // Napisz program z użyciem struktury KandydatNaStudia, która ma posiadać następujące
            // pola: nazwisko, punktyMatematyka, punktyInformatyka, punktyJezykObcy. W trzech ostatnich
            // polach mają być zapisane punkty za przedmioty zdawane na maturze (dla uproszczenia
            // uwzględniamy tylko jeden poziom zdawanej matury, np. podstawowy). Jeden punkt to jeden
            // procent (tj. student, który ma 55% z matematyki ma mieć 55 punktów z tego przedmiotu).
            // Struktura ma posiadać metodę obliczającą łączną liczbę punktów kandydata według
            // przelicznika: 0,6 punktów z matematyki + 0,5 punktów z informatyki + 0,2 punktów z języka
            // obcego. W metodzie Main() utwórz obiekty dla struktury (jako elementy tablicy) dla kilku
            // kandydatów i pokaż listę kandydatów, zawierającą nazwisko i obok, w tej samej linii,
            // obliczoną łączną liczbę punktów

            Console.WriteLine("\n\n================ ZADANIE 6.10 ================\n");

            int il_std = 5;

            KandydatNaStudia[] kand_tab = new KandydatNaStudia[il_std];

            kand_tab[0] = new KandydatNaStudia("Nowak", 55, 98, 100);
            kand_tab[1] = new KandydatNaStudia("Kowalski", 97, 49, 32);
            kand_tab[2] = new KandydatNaStudia("Malinowski", 87, 82, 97);
            kand_tab[3] = new KandydatNaStudia("Kowal", 65, 79, 100);
            kand_tab[4] = new KandydatNaStudia("Malec", 100, 90, 100);


            Console.WriteLine("+------------------------+--------------+");
            Console.WriteLine("|        Nazwisko        |   ilosc pkt  |");
            Console.WriteLine("+------------------------+--------------+");
            foreach (KandydatNaStudia kandydat in kand_tab)
                Console.WriteLine($"|  {kandydat.nazwisko,-20}  |    {kandydat.ilosc_pkt(),-5:F1}     |");
            Console.WriteLine("+------------------------+--------------+");

            Console.Write("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }

}
