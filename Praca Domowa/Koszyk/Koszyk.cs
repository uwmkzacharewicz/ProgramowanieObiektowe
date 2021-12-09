using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace koszyk
{   
    class Koszyk
    {
        //public List<Produkt> lista = new List<Produkt>();
        public Dictionary<Produkt, int> koszykLista = new Dictionary<Produkt, int>();
        private double suma = 0;

        public void DodajProdukt(Produkt prd, int ilosc)
        {
            bool keyExists = koszykLista.ContainsKey(prd);
            if (keyExists)
            {
                koszykLista[prd] += ilosc;
                suma += prd.cena * ilosc;
            }
                
            else
            {
                koszykLista.Add(prd, ilosc);
                suma += prd.cena * ilosc;
            }

            Console.Write("\nPomyślnie dodano do koszyka. Naciśnij dowolny klawisz...");
            Console.ReadKey();

        }

        public void UsunProdukt()
        {
            int pozycja = 1;

            if (koszykLista.Count == 0)
            {
                Console.WriteLine("\nKoszyk jest pusty. Naciśnij dowolny klawisz...");
                Console.ReadKey();
                return;
            }

            Console.Write("\nPodaj numer pozycji: ");
            int wybor = int.Parse(Console.ReadLine());

            foreach (Produkt key in koszykLista.Keys)
            {
                if(pozycja == wybor)
                {
                    Console.WriteLine(key.nazwa + " --> " + koszykLista[key]);
                    suma -= key.cena * koszykLista[key];
                    koszykLista.Remove(key);
                }                    
                pozycja++;
            }

            Console.WriteLine("\nUsunięto produkt z koszyka. Naciśnij dowolny klawisz...");
            Console.ReadKey();

        }

        public double PokazSume()
        {
            double suma = 0;
            foreach (KeyValuePair<Produkt, int> tmp in koszykLista)
            {
                suma += tmp.Key.cena * tmp.Value;
            }

            Console.WriteLine(suma);
            Console.WriteLine(this.suma);
            return suma;
                
                //Console.WriteLine($"{tmp.Key.nazwa,-15}    {tmp.Value}    {tmp.Key.cena} ");

        }

        public void PokazKoszyk()
        {
            int pozycja = 1;

            Console.WriteLine("Twój koszyk:\n");

            if (koszykLista.Count == 0)
            {
                Console.WriteLine("Pusty...");
                return;
            }

            foreach (KeyValuePair<Produkt, int> tmp in koszykLista)
            {
                Console.WriteLine($"[{pozycja}] {tmp.Key.nazwa,-25}    {tmp.Value,-5}    {tmp.Key.cena,4:C2}      {tmp.Key.cena * tmp.Value,4:C2} ");
                pozycja++;
            }

            Console.WriteLine("================================================================");
            Console.WriteLine($"                                                       {this.suma, 4:C2}");
        }

        public void WyczyscKoszyk()
        {
            while (koszykLista.Count != 0)
                koszykLista.Clear();
            Console.Write("\nWyczyszczono koszyk. Naciśnij dowolny klawisz...");
            Console.ReadKey();
        }

        public void ZakonczZakup()
        {
            double sumaK = 0;
            int licznik = 0;
            int ilP = 0;

            Console.Clear();

            Console.WriteLine("Dokonuje zakupu....");
            Console.WriteLine("-----------------------------------------------------------");

            foreach (KeyValuePair<Produkt, int> tmp in koszykLista)
            {
                Thread.Sleep(500);
                licznik++;
                Console.WriteLine($"{licznik}. {tmp.Key.nazwa, -25} {tmp.Value, -5}  {tmp.Key.cena, 8:C2}  {tmp.Key.cena * tmp.Value, 12:C2}");
                ilP += tmp.Value;
            }
            Thread.Sleep(1000);
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"SUMA:                        {ilP, -10}           {this.suma, 4:C2}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("\nDziękujemy za zakupy. Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();

            Environment.Exit(0);
        }




    }
}
