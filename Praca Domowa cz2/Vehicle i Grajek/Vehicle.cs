using System;
using System.Collections.Generic;
using System.Text;

namespace PO_pracaDomowaGrupa2
{
    interface IRideable
    {
        void Ride();
    }

    class Vehicle
    {

    }

    class Car : Vehicle, IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jadę samochodem");
        }
    }

    class Bicycle : Vehicle
    {
        public void Ride()
        {
            Console.WriteLine("Jadę rowerem");
        }

    }
}
