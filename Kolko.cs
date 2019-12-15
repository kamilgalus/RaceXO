using System;
using System.Collections.Generic;
using System.Text;

namespace Przeslo
{
    public class Kolo : IKsztalt
    {
        private char znakPionka = 'O';
        private int pozycjaPionkaO;
        private int pozycjaStartowaO;

        public Kolo()
        {
            pozycjaStartowaO = 0;
            pozycjaPionkaO = pozycjaStartowaO;
        }

        public Kolo(int pozycjaStartowaO)
        {
            this.pozycjaStartowaO = pozycjaStartowaO;
            pozycjaPionkaO = pozycjaStartowaO;
        }

        public void UstawNaStart(char[] tor)
        {
            tor[pozycjaStartowaO] = znakPionka;
        }

        public void Przesun(int iloscMiejsc, char[] tor)
        {
            tor[pozycjaPionkaO] = '_';
            tor[pozycjaPionkaO + iloscMiejsc] = znakPionka;
            pozycjaPionkaO = pozycjaPionkaO + iloscMiejsc;
        }
    }
}
