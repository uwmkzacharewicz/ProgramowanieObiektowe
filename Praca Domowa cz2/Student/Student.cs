using System;
using System.Collections.Generic;
using System.Text;

namespace PO_pracaDomowaGrupa2
{
    public class Student: Osoba
    {
        private string NrAlbumu;
        private int Rok;
        private int NumerGrupy;

        public Student(string imie, string nazwisko, int rokurodzenia, string nralbumu, int rok, int nrgrupy)
            :base(imie, nazwisko, rokurodzenia)
        {
            NrAlbumu = nralbumu;
            Rok = rok;
            NumerGrupy = nrgrupy;
        }

        public override string ToString()
        {
            return base.ToString() + $", nr albumu: {NrAlbumu}, Rok: {Rok}, Numer Grupy: {NumerGrupy}";
        }

        public void ObliczWiekZProtectedOsoba()
        {
            Console.WriteLine("Student: ");
            base.ObliczWiekProtected();
        }

    }
}
