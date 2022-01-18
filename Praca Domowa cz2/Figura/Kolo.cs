using System;
using System.Collections.Generic;
using System.Text;

namespace PO_pracaDomowaGrupa2
{
    class Kolo
    {
        public Punkt WsplSrodka;
        public double R;

        public string Nazwa;

        public Kolo()
        {
            WsplSrodka = new Punkt();
            R = 0;
            Nazwa = "Koło";
        }

        public Kolo(Punkt wspSr, double r, string nazwa = "Koło")
        {
            WsplSrodka = wspSr;
            R = r;
            Nazwa = nazwa;
        }

        public Kolo(float srX, float srY, double promien, string nazwa = "Koło")
        {
            WsplSrodka = new Punkt(srX, srY);
            R = promien;
            Nazwa = nazwa;
        }

        public override string ToString()
        {
            return $"{Nazwa}, środek: O = {WsplSrodka},   promień:  R = {R}";
        }

        public double LiczObwod(double obwod = 0)
        {
            return (2 * Math.PI * R);
        }

        public void PobierzDaneZKlawiatury()
        {
            string input;
            int numberX, numberY, numberR;
            bool isNumberX, isNumberY, isNumberR;


            Console.WriteLine("Podaj współrzędne środka: ");
            Console.Write("współrzędna X: ");
            input = System.Console.ReadLine();
            isNumberX = int.TryParse(input, out numberX);

            Console.Write("współrzędna Y: ");
            input = System.Console.ReadLine();
            isNumberY = int.TryParse(input, out numberY);

            Console.Write("Podaj długość promienia R: ");
            input = System.Console.ReadLine();
            isNumberR = int.TryParse(input, out numberR);

            if (isNumberX && isNumberY && isNumberR)
            {
                WsplSrodka.UstawX(numberX);
                WsplSrodka.UstawY(numberY);
                R = Math.Abs(numberR);
            }
            else
                Console.WriteLine("Niepoprawne dane, nie utworzono punktu.");

        }
        public void Wyswietl()
        {
            Console.WriteLine($"{Nazwa}, środek: O = {WsplSrodka},   promień:  R = {R},   obwód:  {LiczObwod():F2}");
        }
    }
}
