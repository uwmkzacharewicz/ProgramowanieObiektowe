using System;
using System.Collections.Generic;
using System.Text;

namespace PO_pracaDomowaGrupa2
{
    class StudentPierwszegoRoku : Student
    {
        public StudentPierwszegoRoku(string imie, string nazwisko, int rokurodzenia, string nralbumu, int rok, int nrgrupy)
            : base(imie, nazwisko, rokurodzenia, nralbumu, rok, nrgrupy)
        {
            Console.WriteLine("Utworzono obiekt klasy StudentPierwszegoRoku");
        }

        public void WypiszInfoStudentPrRoku()
        {
            Console.WriteLine($"StudentPierwszegoRoku: {Imie}, {Nazwisko}");
            Console.WriteLine("Wywołanie metody ObliczWiek z klasy Osoba:");
            base.ObliczWiekProtected();
            Console.WriteLine("Wywołanie metody ObliczWiek z klasy Student:");
            base.ObliczWiekZProtectedOsoba();
        }

        
    }
}
