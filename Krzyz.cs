using System;
using System.Collections.Generic;
using System.Text;

namespace Przeslo
{
    public class Krzyz : IKsztalt
    {
        private char znakPionka = 'X';
        private int pozycjaPionkaX;
        private int pozycjaStartowaX;


        public Krzyz()
        {
            pozycjaStartowaX = 0;
            pozycjaPionkaX = pozycjaStartowaX;
            
        }

        public Krzyz(int pozycjaStartowaX)
        {
            this.pozycjaStartowaX = pozycjaStartowaX;
            pozycjaPionkaX = pozycjaStartowaX;
        }


        public void UstawNaStart(char[] tor)
        {
            tor[pozycjaStartowaX] = znakPionka;
        }
        public void Przesun(int iloscMiejsc, char[] tor)
        {
            tor[pozycjaPionkaX] = '_';
            tor[pozycjaPionkaX + iloscMiejsc] = znakPionka;
            pozycjaPionkaX = pozycjaPionkaX + iloscMiejsc;
        }

    }
}
