using System;

namespace PD220115
{
    class Program
    {
        static void Main(string[] args)
        {
            Kwadrat kw1 = new Kwadrat();
            Trojkat tr1 = new Trojkat();

            kw1.UstawA(10);
            kw1.WyswietlPole();
            Console.Write("Wyświetlenie z klasy Kwadrat: ");
            Console.WriteLine(kw1.Pole());
        }
    }
}
