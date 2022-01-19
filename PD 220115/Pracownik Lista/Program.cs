using System;
using System.Collections.Generic;

namespace PD220115
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pracownik> listaPracownikow = new List<Pracownik>();
            listaPracownikow.Add(new Programista());
            listaPracownikow.Add(new Projektant());
            listaPracownikow.Add(new Ksiegowy());

            foreach (Pracownik pr in listaPracownikow)
                pr.Pracuj();
            

            Pracownik[] listaP = new Pracownik[3];

            listaP[0] = new Programista();
            listaP[1] = new Projektant();
            listaP[2] = new Ksiegowy();

            foreach (Pracownik pr in listaP)
                pr.Pracuj();


        }
    }
}
