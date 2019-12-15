using System;
using System.Collections.Generic;
using System.Text;

namespace Przeslo
{
    public class Tor
    {
        private char[] torWyscigowyDlaX = new char[20];
        private char[] torWyscigowyDlaO = new char[20];
        
        public Tor()
        {
            for (int i = 0; i < torWyscigowyDlaX.Length; i++)
            {
                torWyscigowyDlaX[i] = '_';
                torWyscigowyDlaO[i] = '_';            
            }



        }

        public void WyswietlTory()
        {
            for (int i = 0; i < torWyscigowyDlaO.Length; i++)
            {
                Console.Write(torWyscigowyDlaO[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < torWyscigowyDlaX.Length; i++)
            {
                Console.Write(torWyscigowyDlaX[i]);
            }

        }

       

        public char[] ZwrocTabliceO()
        {
            return torWyscigowyDlaO;
        }
        public char[] ZwrocTabliceX()
        {
            return torWyscigowyDlaX;
        }





    }
}
