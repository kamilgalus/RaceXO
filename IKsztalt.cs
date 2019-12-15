using System;
using System.Collections.Generic;
using System.Text;

namespace Przeslo
{
    public interface IKsztalt
    {

        public void UstawNaStart(char[] tor);
        public void PrzesunDoPrzodu(int iloscMiejsc, char[] tor);
        public void PrzesunDoTylu(int iloscMiejsc, char[] tor);


    }

}
