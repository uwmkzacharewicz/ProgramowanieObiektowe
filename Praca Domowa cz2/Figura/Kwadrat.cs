using System;
using System.Collections.Generic;
using System.Text;

namespace PO_pracaDomowaGrupa2
{
    class Kwadrat : IOperacje
    {
        public List<Punkt> PktKrawedz = new List<Punkt>(4);
        public string Nazwa;

        public Kwadrat()
        {
            // Musimy użyć metody Capacity, gdyż odwołujemy się do pojemności, ilość elementów jest narazie zerowa!
            for (int i = 0; i < PktKrawedz.Capacity; i++)
                PktKrawedz.Add(new Punkt());
           
            Nazwa = "Kwadrat";
        }

        public Kwadrat(string nazwa) : this()
        {
            Nazwa = nazwa;
        }
        public Kwadrat(List<Punkt> listaPkt, string nazwa = "Kwadrat")
        {
            PktKrawedz = listaPkt;
            Nazwa = nazwa;            
        }

        public Kwadrat(Punkt pkt1, Punkt pkt2, Punkt pkt3, Punkt pkt4, string nazwa = "Kwadrat")
        {
            PktKrawedz.Add(pkt1);
            PktKrawedz.Add(pkt2); 
            PktKrawedz.Add(pkt3);
            PktKrawedz.Add(pkt4);

            Nazwa = nazwa;
        }

        public override string ToString()
        {
            return $"{Nazwa}, punkty: {PktKrawedz[0].Nazwa} = {PktKrawedz[0]}  {PktKrawedz[1].Nazwa} = {PktKrawedz[1]}  " +
                $"{PktKrawedz[2].Nazwa} = {PktKrawedz[2]}  {PktKrawedz[3].Nazwa} = {PktKrawedz[3]}";
        }

        public double LiczObwod()
        {
            return 4 * Math.Abs(PktKrawedz[0].PobierzY()) + Math.Abs(PktKrawedz[1].PobierzY());
        }

        public void PobierzDaneZKlawiatury()
        {
            string input;
            int numberX, numberY;
            bool isNumberX, isNumberY;

            //Punkt nowyPunkt = new Punkt();

            Console.WriteLine("Podaj współrzędne 4 punktów: ");

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Punkt {i+1}, współrzędna X: ");
                input = System.Console.ReadLine();
                isNumberX = int.TryParse(input, out numberX);
                Console.Write($"Punkt {i+1}, współrzędna Y: ");
                input = System.Console.ReadLine();
                isNumberY = int.TryParse(input, out numberY);

                if (isNumberX && isNumberY)
                {
                    if (PktKrawedz.Count == 0)
                        PktKrawedz.Add(new Punkt(numberX, numberY));

                    PktKrawedz[i].UstawX(numberX);
                    PktKrawedz[i].UstawY(numberY);
                }                      
                else
                    Console.WriteLine("Niepoprawne dane, nie utworzono punktu");

            }
            

        }
        public void Wyswietl()
        {
            Console.WriteLine($"{Nazwa}, punkty: {PktKrawedz[0].Nazwa} = {PktKrawedz[0]}  {PktKrawedz[1].Nazwa} = {PktKrawedz[1]}  " +
                $"{PktKrawedz[2].Nazwa} = {PktKrawedz[2]}  {PktKrawedz[3].Nazwa} = {PktKrawedz[3]}, obwód: {LiczObwod()}");
        }


    }
}
