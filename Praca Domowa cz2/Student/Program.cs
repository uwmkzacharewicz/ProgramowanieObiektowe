using System;
using System.Windows.Forms;


namespace PO_pracaDomowaGrupa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba os1 = new Osoba("Karol", "Nowak", 1999);

            os1.WypiszInfo();

            Student st1 = new Student(
                imie: "Karol",
                nazwisko: "Zacharewicz",
                rokurodzenia: 1987,
                nralbumu: "245875",
                rok: 2,
                nrgrupy: 2);

            Console.WriteLine(st1);
            st1.ObliczWiekPrzezProtected();
            st1.ObliczWiekZProtectedOsoba();

            st1.MiejsceZamieszkania = "Olsztyn, Kolorowa 2";

            StudentPierwszegoRoku stp1 = new StudentPierwszegoRoku(
                imie: "Marcin",
                nazwisko: "Kwiatkowski",
                rokurodzenia: 1989,
                nralbumu: "245785",
                rok: 3,
                nrgrupy: 1);

            stp1.WypiszInfoStudentPrRoku();


            Osoba osoba1 = new Osoba("Michał", "Piertuszka");
            Osoba osoba2 = new Osoba("Zuzanna", "Witkowska");

            Student student1 = new Student("Paweł", "Kowal", 1980, "123456", 4, 2);
            Student student2 = new Student("Monika", "Kielich", 1995, "234954", 2, 1);

            osoba1 = student1;
            osoba1.WypiszInfo();
            //student1 = (Student)osoba1;          

        }
    }
}
