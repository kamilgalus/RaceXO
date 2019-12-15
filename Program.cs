using System;
using System.Collections.Generic;

namespace Przeslo
{
    class Program
    {
        static void Main()
        {

            Sedzia szymonMarciniak = new Sedzia();
            Tor circuitdeMonaco = new Tor();

            List<IKsztalt> ListaPionkow = new List<IKsztalt>();
            Kolo pionekKolka = new Kolo(0);
            Krzyz pionekKrzyzyka = new Krzyz(0);

            ListaPionkow.Add(pionekKolka);
            ListaPionkow.Add(pionekKrzyzyka);

            bool decyzjaSedziego;

            ListaPionkow[0].UstawNaStart(circuitdeMonaco.ZwrocTabliceO());
            ListaPionkow[1].UstawNaStart(circuitdeMonaco.ZwrocTabliceX());



            for (int runda = 0; runda < 40; runda++)
            {
                decyzjaSedziego=szymonMarciniak.KogoKolej(runda);
                circuitdeMonaco.WyswietlTory();
                

                if(decyzjaSedziego==true)
                {
                    ListaPionkow[0].Przesun(1, circuitdeMonaco.ZwrocTabliceO());
                }
                else
                {
                    ListaPionkow[1].Przesun(1, circuitdeMonaco.ZwrocTabliceX());
                }

                System.Threading.Thread.Sleep(500);
                Console.Clear();             
            }
            
            

        }

    }
}
