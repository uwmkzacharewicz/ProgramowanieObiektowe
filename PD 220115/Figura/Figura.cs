using System;
using System.Collections.Generic;
using System.Text;

namespace PD220115
{
    abstract class Figura
    {
        protected int A;
        protected int B;
        protected int C;

        public abstract double Pole();

        public virtual void WyswietlPole()
        {
            Console.Write("Wyświetlenie z metody wirtualnej (klasa Figura):");
            Console.WriteLine(Pole());
        }
    }

        

        
    
    
}
