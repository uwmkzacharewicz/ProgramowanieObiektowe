using System;


namespace PO_pracaDomowaGrupa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obiekt1 = new Test();
            Test obiekt2 = new Test();
            Test obiekt3 = new Test();

            obiekt1.liczba = 255;
            obiekt1.poleTestowe.slowo = "slowo";

            obiekt2 = obiekt1;
            // obiekt3 = (Test)obiekt1.Clone();
            obiekt3 = obiekt1.GlebokaKopia();
            obiekt1.liczba = 347;

            obiekt1.poleTestowe.slowo = "kaczka";


            Console.WriteLine(obiekt1.liczba);
            Console.WriteLine(obiekt1.poleTestowe.slowo);
            Console.WriteLine(obiekt2.liczba);
            Console.WriteLine(obiekt2.poleTestowe.slowo);
            Console.WriteLine(obiekt3.liczba);
            Console.WriteLine(obiekt3.poleTestowe.slowo);







        }
    }
}
