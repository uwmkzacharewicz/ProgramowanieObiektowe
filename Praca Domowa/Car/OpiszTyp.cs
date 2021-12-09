class Program
    {

        static int OpiszTyp(int a)
        {
            return a;
        }

        static double OpiszTyp(double b)
        {
            return b;
        }

        static void OpiszTyp(double a, double b)
        {
            Console.WriteLine($"Podałeś {a} i {b}");
        }

        static string OpiszTyp(string napis)
        {
            return napis;
        }

        static void OpiszTyp(int a, double b, string napis)
        {
            Console.WriteLine($"Podałeś int: {a}, double: {b} i string: {napis}");
        }

        static char OpiszTyp(char ch)
        {
            return ch;
        }

        static void OpiszTyp(int a, char ch, double b, string np)
        {
            Console.WriteLine($"Podałeś int: {a}, char: {ch}, double: {b} i string: {np}");
        }

        static void Main(string[] args)
        {
            int a = 1;
            double b = 1.25;
            string napis = "napis";
            char ch = 'K';

            Console.WriteLine($"{OpiszTyp(a)}");
            OpiszTyp(1.55, 1.25);
            Console.WriteLine($"{OpiszTyp(napis)}");
            OpiszTyp(5, 1.25, "napis");
            Console.WriteLine($"{OpiszTyp(ch)}");
            OpiszTyp(5, 'X', 1.25, "napis");

        }