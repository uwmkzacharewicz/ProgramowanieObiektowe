using System;
using System.Collections.Generic;
using System.Text;

namespace PO_pracaDomowaGrupa2
{
    class Test : IClonable
    {
        public int liczba;
        public Test2 poleTestowe;

        public Test()
        {
            Test2 nowy = new Test2();
            poleTestowe = nowy;

        }

        public Object Clone()
        {
            return MemberwiseClone();
        }

        public Test GlebokaKopia()
        {
            Test tempTest = new Test();
            tempTest.liczba = this.liczba;
            tempTest.poleTestowe.slowo = this.poleTestowe.slowo;
            return tempTest;
        }

    }
}
