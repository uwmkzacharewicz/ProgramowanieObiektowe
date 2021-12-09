using System;
using System.Collections.Generic;
using System.Text;

namespace PO_pracadomowa1
{
    class Car
    {
        public string marka;
        private int _Rok;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;

        public int Rok
        {
            get { return _Rok; }
            set
            {
                if (value < 1769 || value > 2017)
                {
                    Console.WriteLine("Podano zły rocznik");
                    //_Rok = 0;
                    return;
                }
                _Rok = value;
            }
        }

        public void podajModel(string mod)
        {
            model = mod;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (this.srednieSpalanie * dlugoscTrasy) / 100;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }

        public void PokazDane()
        {
            Console.WriteLine($"Marka: {marka}, rocznik: {_Rok}, średnie spalanie: {srednieSpalanie} litr/100 km");
        }
    }
}
