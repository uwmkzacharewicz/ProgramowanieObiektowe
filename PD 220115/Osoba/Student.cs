using System;
using System.Collections.Generic;
using System.Text;

namespace PD220115
{
    class Student : Osoba
    {
        public int rokStudiow;
        public int nrGrupy;
        public string nrAlbumu;

        public Student() : base()
        {
            rokStudiow = 2000;
            nrGrupy = 1;
            nrAlbumu = "123456";
        }
        public Student(int rokStudiow, int nrGrupy, string nrAlbumu)
        {
            this.rokStudiow = rokStudiow;
            this.nrGrupy = nrGrupy;
            this.nrAlbumu = nrAlbumu ?? throw new ArgumentNullException(nameof(nrAlbumu));
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            //Console.WriteLine($"Student: {Imie} {Nazwisko}");
        }
    }
}
