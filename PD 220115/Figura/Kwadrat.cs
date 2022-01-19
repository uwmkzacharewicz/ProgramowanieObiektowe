using System;
using System.Collections.Generic;
using System.Text;

namespace PD220115
{
    class Kwadrat : Figura
    {
        public void UstawA(int a)
        {
            A = a;
        }


        public override double Pole()
        {
            return 1.0 * A * A;           
        }

        public override void WyswietlPole()
        {
            base.WyswietlPole();
        }
    }
}
