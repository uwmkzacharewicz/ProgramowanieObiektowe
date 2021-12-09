using System;
using System.Collections.Generic;
using System.Text;

namespace LiczbyZespolone
{
    class LiczbaZespolona
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public LiczbaZespolona(double a, double b)
        {
            Re = a;
            Im = b;
        }

        public override string ToString()
        {
            string _out = "z = ";

            if (Re == 0)
                _out += $"{Im}j";
            else
            {
                _out += Re;
                if (Im > 0)
                    _out += $" + {Im}j";
                else if (Im == 0)
                    _out += "";
                else
                    _out += $" - {Math.Abs(Im)}j";
            }

            return _out;
        }

        public void show()
        {
            if(Im >= 0)
                Console.WriteLine($"z = {Re} + {Im}j");
            else
                Console.WriteLine($"z = {Re} - {Math.Abs(Im)}j");
        }

        public LiczbaZespolona sprzezenie()
        {
            return new LiczbaZespolona(Re, -Im);
        }

        public double Modul()
        {
            return Math.Sqrt(Re * Re + Im * Im);
        }

        public static LiczbaZespolona operator +(LiczbaZespolona a, LiczbaZespolona b) => new LiczbaZespolona(a.Re + b.Re, a.Im + b.Im);
        public static LiczbaZespolona operator -(LiczbaZespolona a, LiczbaZespolona b) => new LiczbaZespolona(a.Re - b.Re, a.Im - b.Im);

       

    }
}
