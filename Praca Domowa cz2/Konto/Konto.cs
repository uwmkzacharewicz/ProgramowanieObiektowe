using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace PO_pracaDomowaGrupa2
{    
    enum TypOperacji
    {
        KasaWplata,
        KasaWyplata,
        BankomatWplata,
        BankomatWyplata,
        PrzelewZlecono,
        PrzelewOtrzymano,
        KartaPlatnosc
    }
    class Konto
    {
        private List<string> ListaOperacji = new List<string>();

        public Konto(string wlasciciel, decimal stanKonta)
        {
            WlascicielKonta = wlasciciel;
            StanKonta = stanKonta;
            SaldoPoczatkowe = stanKonta;
            SaldoKoncowe = stanKonta;
            ID_Klient = NextKlientID;
            NextKlientID++;
        }
        public decimal SaldoPoczatkowe { get; set; }
        public decimal SaldoKoncowe { get; set; }
        public string WlascicielKonta { get; set; }
        public decimal StanKonta { get; set; }
        public int ID_Klient { get; private set; }

        private static int NextKlientID = 1000;


        public void WyswietlWyciag()
        {
            string path = ID_Klient + ".txt";


            if (!File.Exists(path))
            {
                Console.WriteLine("Brak operacji na koncie");
                return;
            }

            StreamReader reader = File.OpenText(path);
            string str = "";

            while ((str = reader.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
            reader.Close();
        }

        public void GenerujWyciag()
        {
            string path = ID_Klient + ".txt";
            StreamWriter writer = File.CreateText(path);

            //writer = File.CreateText(path);
            writer.WriteLine(String.Concat(Enumerable.Repeat("-", 80)));
            writer.WriteLine($"Właściciel: {WlascicielKonta}        Identyfikator klienta: {ID_Klient}");
            writer.WriteLine($"Saldo początkowe: {SaldoPoczatkowe,-10:C2}");
            writer.WriteLine($"Saldo końcowe: {SaldoKoncowe,-10:C2}");
            writer.WriteLine();

            writer.WriteLine(String.Concat(Enumerable.Repeat("-", 80)));
            writer.WriteLine();
            writer.WriteLine("     OPERACJA                             KWOTA              SALDO     ");
            writer.WriteLine();
            writer.WriteLine(String.Concat(Enumerable.Repeat("-", 80)));

            //writer = new StreamWriter(path, true);           


            if (ListaOperacji.Count == 0)
            {
                writer.WriteLine("Brak operacji na koncie");
            }
            else
            {
                foreach (string operacja in ListaOperacji)
                {
                    writer.WriteLine(operacja);
                }
            }

            writer.Close();
        }

        public void OperacjaNaRachunku(string zleceniodawna, decimal kwota, TypOperacji typ)
        {
            string nazwaOperacji = SprawdzOperacje(typ);

            if (typ == TypOperacji.BankomatWplata || typ == TypOperacji.KasaWplata || typ == TypOperacji.PrzelewOtrzymano)
            {
                StanKonta += kwota;
            }
            else
            {
                if (kwota > StanKonta)
                {
                    Console.WriteLine("Brak środków na koncie. Transakcja odrzucona\n");
                    return ;
                }
                StanKonta += (-1)*kwota;
            }

            StworzOperacje(nazwaOperacji, zleceniodawna, kwota);

            //string operacja, opis;
            //operacja = $"{DateTime.Now}\n";
            //opis = $"[{ID_Klient}] {nazwaOperacji, -30}" + $"kwota: {kwota, -20:C2}"  + $"Saldo po operacji: {StanKonta,-20:C2}\n";
            //operacja += $"{nazwaOperacji, -30}" + $"{kwota, 20:C2}"  + $"{StanKonta, 20:C2}\n";
            //operacja += $"{zleceniodawna}\n";
            //operacja += String.Concat(Enumerable.Repeat("-", 80));

            //SaldoKoncowe = StanKonta;
            //Console.WriteLine($"Saldo końcowe: {SaldoKoncowe}");

            ////_out = $"{DateTime.Now} Przelew do {Odbiorca}: {kwota:C2}, " + String.Concat(Enumerable.Repeat("-", 20)) + $" saldo po operacji: {StanKonta:C2}";
            //Console.WriteLine(opis);
            //ListaOperacji.Add(operacja);
 
        }

        public void StworzOperacje(string nazwaoperacji, string zleceniodawca, decimal kwota)
        {
            string operacja, opis;
            operacja = $"{DateTime.Now}\n";
            opis = $"[{ID_Klient}] {nazwaoperacji,-30}" + $"kwota: {kwota,-20:C2}" + $"Saldo po operacji: {StanKonta,-20:C2}\n";
            operacja += $"{nazwaoperacji,-30}" + $"{kwota,20:C2}" + $"{StanKonta,20:C2}\n";
            operacja += $"{zleceniodawca}\n";
            operacja += String.Concat(Enumerable.Repeat("-", 80));

            SaldoKoncowe = StanKonta;
            Console.WriteLine($"Saldo końcowe: {SaldoKoncowe}");
            Console.WriteLine(opis);
            ListaOperacji.Add(operacja);

        }


        public override string ToString()
        {
            return $"[{ID_Klient}] {WlascicielKonta}, stan konta: {StanKonta}";
        }

        static string SprawdzOperacje(TypOperacji typ)
        {
            string operacja ="";

            switch (typ)
            {
                case TypOperacji.KasaWplata:
                    {
                        operacja = "WPŁATA W KASIE BANKU";
                        break;
                    }
                case TypOperacji.KasaWyplata:
                    {
                        operacja = "WYPŁATA W KASIE BANKU";
                        break;
                    }
                case TypOperacji.PrzelewZlecono:
                    {
                        operacja = "PRZELEW WYCHODZACY";
                        break;
                    }
                case TypOperacji.PrzelewOtrzymano:
                    {
                        operacja = "PRZELEW KRAJOWY";
                        break;
                    }
                case TypOperacji.KartaPlatnosc:
                    {
                        operacja = "TRANSAKCJA KARTĄ DEBETOWĄ";
                        break;
                    }
                case TypOperacji.BankomatWplata:
                    {
                        operacja = "WPŁATA BANKOMAT";
                        break;
                    }
                case TypOperacji.BankomatWyplata:
                    {
                        operacja = "WYPŁATA Z BANKOMATU";
                        break;
                    }
            }

            return operacja;
        }
   
     

    }
}
