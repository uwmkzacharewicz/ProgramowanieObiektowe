using System;

namespace LiczbyZespolone
{
    class Program
    {
        static void Main(string[] args)
        {
            LiczbaZespolona cpx1 = new LiczbaZespolona(1, 8);
            LiczbaZespolona cpx2 = new LiczbaZespolona(2, -6);
            LiczbaZespolona cpx3 = cpx1 + cpx2;
            LiczbaZespolona cpx4 = new LiczbaZespolona(0, 2);
            LiczbaZespolona cpx5 = new LiczbaZespolona(2, 0);
            LiczbaZespolona cpx6 = new LiczbaZespolona(-12, 5);
            LiczbaZespolona cpx7 = new LiczbaZespolona(2, 3);

            Console.WriteLine($"cpx1: {cpx1}, moduł: {cpx1.Modul(),0:G2}");
            Console.WriteLine($"cpx2: {cpx2}");
            Console.WriteLine($"cpx1 + cpx2: {cpx1 + cpx2}");
            Console.WriteLine($"cpx1 - cpx2: {cpx1 - cpx2}");
            Console.WriteLine($"sprzężenie cpx1: {cpx1.sprzezenie()}");
            Console.WriteLine($"sprzężenie cpx4: {cpx4.sprzezenie()}");
            Console.WriteLine($"cpx4: {cpx4}");
            Console.WriteLine($"cpx5: {cpx5}");
            Console.WriteLine($"cpx6: {cpx6}");
            Console.WriteLine($"sprzężenie cpx6: {cpx6.sprzezenie()}");

        }
    }
}
