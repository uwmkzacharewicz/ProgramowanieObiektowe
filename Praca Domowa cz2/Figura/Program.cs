using System;
using System.Collections.Generic;
using System.Text;


namespace PO_pracaDomowaGrupa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt pktA = new Punkt(1, 1, "A");
            Punkt pktB = new Punkt(1, 3, "B");
            Punkt pktC = new Punkt(3, 1, "C");
            Punkt pktD = new Punkt(3, 3, "D");
            Punkt pktE = new Punkt(-4, -2, "E");
            Punkt pktF = new Punkt(2, 5, "F");
            Punkt pktG = new Punkt(-1, -2, "G");
            Punkt pktH = new Punkt(-1, 0, "H");
            Punkt pktI = new Punkt(1, 0, "I");
            Punkt pktJ = new Punkt(1, -2, "J");

            List<Punkt> listaPunktow1 = new List<Punkt> { pktA, pktB, pktC, pktD };
            var listaPunktow2 = new List<Punkt> { new Punkt(1, 1), new Punkt(1, 3), new Punkt(3, 1), new Punkt(3, 3) };
            List<Punkt> listaPunktow3 = new List<Punkt>();
            List<Punkt> listaPunktow4 = new List<Punkt> { pktG, pktH, pktI, pktJ };


            Kwadrat kw1 = new Kwadrat("kwadrat nr 1");
            Kwadrat kw2 = new Kwadrat(listaPunktow1, "kwadrat nr 2");
            Kwadrat kw3 = new Kwadrat(pktG, pktH, pktI, pktJ, "kwadrat nr 3");

            Console.WriteLine(kw1);
            //kw1.PobierzDaneZKlawiatury();
            kw1.Wyswietl();
            kw2.Wyswietl();
            kw3.Wyswietl();

            Kolo kolo1 = new Kolo();
            Kolo kolo2 = new Kolo(srX: 5, srY: 12, promien: 4, "Koło nr 2");
            Kolo kolo3 = new Kolo(pktE, 5, "Koło nr 3");

            Console.WriteLine(kolo1);
            Console.WriteLine(kolo2);
            kolo2.Wyswietl();
            kolo3.Wyswietl();







            //Kwadrat kw1 = new Kwadrat();
            //Kolo kol1 = new Kolo();


            //Console.WriteLine(kw1.Nazwa);


            //var listaPunktow = new List<Punkt> { new Punkt(1,1), new Punkt(1,3), new Punkt(3,1), new Punkt(3,3) };

            //Kwadrat kw2 = new Kwadrat(listaPunktow1);


            ////foreach (Punkt pkt in kw1.PktKrawedz)
            ////{
            ////    Console.WriteLine(pkt.X);
            ////    Console.WriteLine(pkt.Y);
            ////}

            //List<Punkt> Krawedz = new List<Punkt>(4);

            //Console.WriteLine(Krawedz.Capacity);

            //kw1.Wyswietl();
            //kw2.Wyswietl();
            //Console.WriteLine(kw2.LiczObwod());

            //kol1.Wyswietl();
            ////kw2.PobierzDaneZKlawiatury();

            //Punkt pktZ = new Punkt();

            //pktZ.PobierzDaneZKlawiatury();
            //Console.WriteLine(pktZ);

            //Kolo kol2 = new Kolo();
            //kol2.PobierzDaneZKlawiatury();
            //kol2.Wyswietl();




        }
    }
}
