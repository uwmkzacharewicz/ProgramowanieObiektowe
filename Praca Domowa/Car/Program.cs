using System;

namespace PO_pracadomowa1
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName;
            carName = "Mój Samochód";
            Console.WriteLine($"{carName}");

            Car car1 = new Car();
         
            car1.marka = "Audi";
            car1.podajModel("A3");
            car1.Rok = 2008;
            car1.srednieSpalanie = 6;
            car1.PokazDane();

            double cenaPaliwa = 6.15;
            int przejazd = 180;

            Console.WriteLine($"Koszt przejazdu dla {przejazd} km: {car1.ObliczKosztPrzejazdu(przejazd, cenaPaliwa), 0:C2}");

            //Car car2 = new Car();
            //car2.marka = "Audi";
            //car2.rok = 2009;
            //car2.PokazDane();

            //car1 = car2;
            //Console.WriteLine("car1 = car2");
            //Console.WriteLine("car1: ");
            //car1.PokazDane();
            //Console.WriteLine("car2: ");
            //car2.PokazDane();         
         }
    }
}
