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



            for (int runda = 0;; runda++)
            {
                int okrazenie;
                decyzjaSedziego = szymonMarciniak.KogoKolej(runda);
                circuitdeMonaco.WyswietlTory();
                okrazenie = runda / 38;

                if (okrazenie%2==0) 
                {
                    if (decyzjaSedziego == true)
                    {
                        ListaPionkow[0].PrzesunDoPrzodu(1, circuitdeMonaco.ZwrocTabliceO());
                    }
                    else
                    {
                        ListaPionkow[1].PrzesunDoPrzodu(1, circuitdeMonaco.ZwrocTabliceX());
                    }
                }


                if (okrazenie%2==1) 
                {

                    if (decyzjaSedziego == false)
                    {
                        ListaPionkow[0].PrzesunDoTylu(1, circuitdeMonaco.ZwrocTabliceO());
                    }
                    else
                    {
                        ListaPionkow[1].PrzesunDoTylu(1, circuitdeMonaco.ZwrocTabliceX());
                    }
                }








                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }



        }

    }
}
