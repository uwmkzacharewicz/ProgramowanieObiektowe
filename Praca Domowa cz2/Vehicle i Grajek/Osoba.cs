using System;
using System.Collections.Generic;
using System.Text;

namespace PO_pracaDomowaGrupa2
{
    class Osoba : IGitarzysta, ISkrzypek
    {
        public void Graj()
        {
            Console.WriteLine("Gram, ale nie wiem na czym");
        }

        void IGitarzysta.Graj()
        {
            Console.WriteLine("Gram na gitarze");
        }

        void ISkrzypek.Graj()
        {
            Console.WriteLine("Gram na skrzypcach");
        }
    }
}
