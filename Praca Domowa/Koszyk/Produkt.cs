using System;
using System.Collections.Generic;
using System.Text;

namespace koszyk
{
    class Produkt
    {
        public string nazwa { get; set; }
        public double cena { get; set; }

        public Produkt(string naz, double c)
        {
            nazwa = naz;
            cena = c;
        }

        public void PokazProdukt()
        {
            Console.WriteLine($"{nazwa,-25}  {cena,4:C2}");
        }

       


    }
}
