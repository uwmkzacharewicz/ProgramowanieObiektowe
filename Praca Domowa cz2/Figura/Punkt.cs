using System;
using System.Collections.Generic;
using System.Text;

namespace PO_pracaDomowaGrupa2
{
    public class Punkt
    {
        private double X;
        private double Y;

        //public double X { get; set; }
        //public double Y { get; set; }

        public string Nazwa;

        public Punkt()
        {
            X = 0;
            Y = 0;
            Nazwa = "Punkt";
        }
        public Punkt(double x, double y, string nazwa = "Punkt")
        {
            X = x;
            Y = y;
            Nazwa = nazwa;
        }

        public double PobierzX()
        {
            return X;
        }

        public double PobierzY()
        {
            return Y;
        }

        public void UstawX(double x)
        {
            X = x;
        }

        public void UstawY(double y)
        {
            Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public void PobierzDaneZKlawiatury()
        {
            string input;
            int numberX, numberY;
            bool isNumberX, isNumberY;

            Console.WriteLine("Podaj współrzędne punktu: ");

            Console.Write("współrzędna X: ");
            input = System.Console.ReadLine();
            isNumberX = int.TryParse(input, out numberX);
            Console.Write("współrzędna Y: ");
            input = System.Console.ReadLine();
            isNumberY = int.TryParse(input, out numberY);

            if (isNumberX && isNumberY)
            {
                UstawX(numberX);
                UstawY(numberY);

            }
            else
                Console.WriteLine("Niepoprawne dane, nie utworzono punktu.");
        }
    }
}
