using System;
using System.Collections.Generic;
using System.Text;

namespace Przeslo
{
    public class Sedzia
    {      
        public bool KogoKolej(int nrRundy)
        {
            if (nrRundy%2== 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
