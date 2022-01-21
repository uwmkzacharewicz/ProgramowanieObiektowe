using System;
using System.Collections.Generic;

namespace PD220115
{
    class GeneralException : Exception
    {

    }
    class Program
    {
        public static void metoda23()
        {
            throw new NotImplementedException("To do...");
        }

        static void Main(string[] args)
        {

            try
            {
                metoda23();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Przechwyciłem wyjątek: {0}", e.Message);
            }

           

        }
    }
}