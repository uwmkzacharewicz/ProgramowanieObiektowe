using System;

namespace Zadania_ps
{    class Program
    {
        static void Main(string[] args)
        {

            // ZADANIE 2.1
            Console.WriteLine("\n\n================ ZADANIE 2.1 ================\n");
            double C = 0;
            double F = 0;

            Console.Write("Podaj stopnie C: ");
            C = double.Parse(Console.ReadLine());
            F = 32 + 1.8 * C;

            Console.WriteLine("{0,-4:F1} stopni Celsjusza to {1,-4:F1} Fahrenheita", C, F);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();
            
            // ZADANIE 2.2
            Console.WriteLine("\n\n================ ZADANIE 2.1 ================\n");

            double a, b, c;
            double delta = 0;

            Console.Write("Podaj współczynnik a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Podaj współczynnik b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Podaj współczynnik c: ");
            c = double.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;

            Console.WriteLine("a = {0,-4:F2}, b = {1,-4:F2}, c = {2, -4:F2}", a, b, c);
            Console.WriteLine("delta równa jest {0,-4:F2}", delta);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();


            // ZADANIE 2.3
            Console.WriteLine("\n\n================ ZADANIE 2.3 ================\n");

            int wzrost, waga;
            double wzrost_m;
            double bmi = 0;

            Console.Write("Podaj swój wzrost w cm: ");
            wzrost = int.Parse(Console.ReadLine());
            Console.Write("Podaj swoją wagę w kg: ");
            waga = int.Parse(Console.ReadLine());

            wzrost_m = (double)wzrost / 100;
            bmi = (double)waga / (wzrost_m * wzrost_m);

            Console.WriteLine("Twoje BMI wynosi: {0,-2:F2}", bmi);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 2.4
            Console.WriteLine("\n\n================ ZADANIE 2.4 ================\n");

            int x_4 = 100;
            Console.WriteLine(++x_4 * 2);
            // ++x, x zwiekszy swoją wartość przed wykonaniem działania

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 2.5
            Console.WriteLine("\n\n================ ZADANIE 2.5 ================\n");

            int x_5 = 2, y_5 = 3;
            x_5 *= y_5 * 2;
            Console.WriteLine(x_5);
            // najpierw wykona się prawa strona równania

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 2.6
            Console.WriteLine("\n\n================ ZADANIE 2.6 ================\n");

            int x_6, y_6 = 4;
            x_6 = (y_6 -= 2);     // x = 2, y6 = 2
            Console.WriteLine("x = {0}, y = {1}", x_6, y_6);
            x_6 = y_6++;          // x = 2, y = 3
            Console.WriteLine("x = {0}, y = {1}", x_6, y_6);
            x_6 = y_6--;          // x = 3, y = 2
            Console.WriteLine("x = {0}, y = {1}", x_6, y_6);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 2.7
            Console.WriteLine("\n\n================ ZADANIE 2.7 ================\n");

            int x_7, y_7 = 5;
            x_7 = ++y_7 * 2;        // x = 12, y = 6 
            Console.WriteLine("x = {0}, y = {1}", x_7, y_7);
            x_7 = y_7++;            // x = 6, y = 7
            Console.WriteLine("x = {0}, y = {1}", x_7, y_7);
            x_7 = y_7--;            // x = 7, y = 6
            Console.WriteLine("x = {0}, y = {1}", x_7, y_7);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 2.8
            Console.WriteLine("\n\n================ ZADANIE 2.8 ================\n");

            bool x_8;
            int y_8 = 1;
            int z_8 = 1;

            x_8 = (y_8 == 1 && z_8++ == 1);
            // x = True, y = 1, y = 2
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x_8, y_8, z_8);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 2.9
            Console.WriteLine("\n\n================ ZADANIE 2.9 ================\n");

            int x_9 = 1, y_9 = 4, z_9 = 2;
            bool wynik_9 = (x_9++ > 1 && y_9++ == 4 && z_9-- > 0);
            // do porównania: x = 1, y = 4, z = 2
            // pierwszy warunek nie spelniony 1>4 wiec false
            // reszta && się nie wykona!!! a więc y i z bez zmian
            // po x/y/z ++: x = 2, y = 4, z = 2
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik_9, x_9, y_9, z_9);

            int x_10 = 1, y_10 = 4, z_10 = 2;
            bool wynik = (x_10++ > 1 & y_10++ == 4 && z_10-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x_10, y_10, z_10);

            Console.Write("\nNaciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();

            // ZADANIE 2.10
            Console.WriteLine("\n\n================ ZADANIE 2.10 ================\n");

            // Należy wykonać rzutowanie
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia_1 = (double)osoby / powierzchnia;
            double gestoscZaludnienia_2 = 1.0 * osoby / powierzchnia;
            Console.WriteLine(gestoscZaludnienia_1);
            Console.WriteLine(gestoscZaludnienia_2);

            Console.Write("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}
